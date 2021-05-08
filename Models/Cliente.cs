using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiWpossVideojuegos.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            VentaAlquilers = new HashSet<VentaAlquiler>();
        }

        public int IdCliente { get; set; }
        public string Nit { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public int? Edad { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<VentaAlquiler> VentaAlquilers { get; set; }
    }
}
