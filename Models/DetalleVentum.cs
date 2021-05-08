using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiWpossVideojuegos.Models
{
    public partial class DetalleVentum
    {
        public int IdDetalle { get; set; }
        public DateTime? FechaVenta { get; set; }
        public int? TipoVenta { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Descuento { get; set; }
        public int? IdVideoGame { get; set; }
        public int? IdVenta { get; set; }

        public virtual VentaAlquiler IdVentaNavigation { get; set; }
        public virtual VideoJuego IdVideoGameNavigation { get; set; }
    }
}
