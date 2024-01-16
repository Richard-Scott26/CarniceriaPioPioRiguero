using System;
using System.Collections.Generic;

namespace DemoBasic.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleCompras = new HashSet<DetalleCompra>();
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int Idproducto { get; set; }
        public string Numero { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public int Idsubcategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Existencia { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool? Estado { get; set; }

        public virtual Subcategoria IdsubcategoriaNavigation { get; set; } = null!;
        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
