using System;
using System.Collections.Generic;

namespace DemoBasic.Models
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            Compras = new HashSet<Compra>();
        }

        public int Idproveedor { get; set; }
        public string Compañia { get; set; } = null!;
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string Titulocontacto { get; set; } = null!;
        public string Nombrecontacto { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public string? Email { get; set; }
        public string? Paginaweb { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
    }
}
