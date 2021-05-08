using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiWpossVideojuegos.Models
{
    public partial class VentaAlquiler
    {
        public VentaAlquiler()
        {
            DetalleVenta = new HashSet<DetalleVentum>();
        }

        public int IdVenta { get; set; }
        public string TipoComprobante { get; set; }
        public string SerieComprobante { get; set; }
        public string NumComprobante { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string Impuesto { get; set; }
        public decimal? Total { get; set; }
        public string Estado { get; set; }
        public int? IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual ICollection<DetalleVentum> DetalleVenta { get; set; }
    }
}
