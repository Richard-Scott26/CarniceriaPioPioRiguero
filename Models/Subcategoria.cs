using System;
using System.Collections.Generic;

namespace DemoBasic.Models
{
    public partial class Subcategoria
    {
        public Subcategoria()
        {
            Productos = new HashSet<Producto>();
        }

        public int Idsubcategoria { get; set; }
        public int Idcategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public bool? Estado { get; set; }

        public virtual Categoria IdcategoriaNavigation { get; set; } = null!;
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
