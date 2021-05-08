using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWpossVideojuegos.Dto
{
    public class BodyVideojuego
    {
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public string Año { get; set; }
        public string Protagonista { get; set; }
        public string Director { get; set; }
        public string Productor { get; set; }
        public string Tecnologia { get; set; }
        public int? Precio { get; set; }
        public int? Stock { get; set; }
        public string Imagen { get; set; }
        public int? IdDetalle { get; set; }
    }
}
