using Entities.Models.LOGIN;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;
using System.Security.Cryptography;
using System.Text;
using Shared.DataTransferObjects;
using Service;

namespace API.Presentation.Controllers;

[Route("api/usuario")]
[ApiController]
public class UsuarioController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly RepositoryContext _context;

    public UsuarioController(IServiceManager service, RepositoryContext context)
    {
        _service = service;
        _context = context;
    }

    [HttpPost("registro")]
    public async Task<ActionResult<Usuario>> Registro(UsuarioDto usuarioDto)
    {
        if (await UsuarioExiste(usuarioDto.NombreUsuario))
        {
            return BadRequest("El nombre de usuario ya existe");
        }

        using var hmac = new HMACSHA512();

        var usuario = new Usuario
        {
            NombreUsuario = usuarioDto.NombreUsuario,
            CorreoElectronico = usuarioDto.CorreoElectronico,
            Contrasena = "default", // Asignar un valor predeterminado
            ContrasenaHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(usuarioDto.Contrasena)),
            ContrasenaSalt = hmac.Key,
            Rol = usuarioDto.Rol
        };


        _context.Usuarios.Add(usuario);
        await _context.SaveChangesAsync();

        return Ok(usuario);
    }

    private async Task<bool> UsuarioExiste(string nombreUsuario)
    {
        return await _context.Usuarios.AnyAsync(u => u.NombreUsuario == nombreUsuario);
    }

    [HttpPost("login")]
    public async Task<ActionResult<string>> Login(LoginDto loginDto, [FromServices] TokenService tokenService)
    {
        var usuario = await _context.Usuarios
            .SingleOrDefaultAsync(u => u.NombreUsuario == loginDto.NombreUsuario);

        if (usuario == null)
        {
            return Unauthorized("Usuario inválido");
        }

        using var hmac = new HMACSHA512(usuario.ContrasenaSalt);

        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Contrasena));

        for (int i = 0; i < computedHash.Length; i++)
        {
            if (computedHash[i] != usuario.ContrasenaHash[i]) return Unauthorized("Contraseña inválida");
        }

        return tokenService.GenerarTokenJWT(usuario.NombreUsuario, usuario.Rol);
    }


    // Resto de tu controlador...
}


