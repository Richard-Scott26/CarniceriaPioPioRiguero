using System;
using System.Collections.Generic;

namespace DemoBasic.Models
{
    public partial class DetalleVenta
    {
        public int Iddetalleventa { get; set; }
        public int Idventa { get; set; }
        public int Idproducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precioventa { get; set; }
        public decimal Descuento { get; set; }
        public decimal Subtotal { get; set; }

        public virtual Producto IdproductoNavigation { get; set; } = null!;
        public virtual Venta IdventaNavigation { get; set; } = null!;
    }
}
