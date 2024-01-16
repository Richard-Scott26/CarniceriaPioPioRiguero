using System;
using System.Collections.Generic;

namespace DemoBasic.Models
{
    public partial class Compra
    {
        public Compra()
        {
            DetalleCompras = new HashSet<DetalleCompra>();
        }

        public int Idcompra { get; set; }
        public DateTime Fecha { get; set; }
        public int Idproveedor { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        public virtual Proveedore IdproveedorNavigation { get; set; } = null!;
        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; }
    }
}
