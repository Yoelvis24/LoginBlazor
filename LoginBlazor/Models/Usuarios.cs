using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginBlazor.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Username { get; set; }
        public string Contraseña { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Username = string.Empty;
            Contraseña = string.Empty;
        }
    }
}
