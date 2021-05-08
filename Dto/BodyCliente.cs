using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWpossVideojuegos.Dto
{
    public class BodyCliente
    {
 
        public string Nit { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public int? Edad { get; set; }
        public string Telefono { get; set; }
    }
}
