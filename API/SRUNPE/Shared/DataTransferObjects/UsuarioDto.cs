using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects;

public class UsuarioDto
{
    public int Id { get; set; }
    public string NombreUsuario { get; set; }
    public string CorreoElectronico { get; set; }
    public string Contrasena { get; set; }
    public string Rol { get; set; }

}
