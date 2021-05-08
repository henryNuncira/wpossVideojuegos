using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWpossVideojuegos.Dto
{
    public class BodyVenta
    {
        public string TipoComprobante { get; set; }
        public string SerieComprobante { get; set; }
        public string NumComprobante { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string Impuesto { get; set; }
        public decimal? Total { get; set; }
        public string Estado { get; set; }
        public int? IdCliente { get; set; }
    }
}
