using System;
using System.Collections.Generic;

namespace DemoBasic.Models
{
    public partial class Venta
    {
        public Venta()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int Idventa { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
