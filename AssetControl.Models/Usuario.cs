using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetControl.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Activo { get; set; }
    }
}
