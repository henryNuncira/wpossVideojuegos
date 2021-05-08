using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiWpossVideojuegos.Models
{
    public partial class VideoJuego
    {
        public VideoJuego()
        {
            DetalleVenta = new HashSet<DetalleVentum>();
        }

        public int IdVideoJuego { get; set; }
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

        public virtual ICollection<DetalleVentum> DetalleVenta { get; set; }
    }
}
