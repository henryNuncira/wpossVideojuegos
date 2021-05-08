using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWpossVideojuegos.Dto
{
    public class BodyDetalle
    {
        public DateTime? FechaVenta { get; set; }
        public int? TipoVenta { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Descuento { get; set; }
        public int? IdVideoGame { get; set; }
        public int? IdVenta { get; set; }

    }
}
