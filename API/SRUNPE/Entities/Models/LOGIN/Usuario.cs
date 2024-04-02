using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.LOGIN;

public class Usuario
{
    public int Id { get; set; }
    public string NombreUsuario { get; set; }
    public string CorreoElectronico { get; set; }
    public string Contrasena { get; set; }
    public string Rol { get; set; }

    public byte[] ContrasenaHash { get; set; }
    public byte[] ContrasenaSalt { get; set; }
}
