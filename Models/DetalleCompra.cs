using System;
using System.Collections.Generic;

namespace DemoBasic.Models
{
    public partial class DetalleCompra
    {
        public int Iddetallecompra { get; set; }
        public int Idcompra { get; set; }
        public int Idproducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Preciocompra { get; set; }
        public decimal Descuento { get; set; }
        public decimal Subtotal { get; set; }

        public virtual Compra IdcompraNavigation { get; set; } = null!;
        public virtual Producto IdproductoNavigation { get; set; } = null!;
    }
}
