using System;
using System.Collections.Generic;

namespace DemoBasic.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Subcategoria = new HashSet<Subcategoria>();
        }

        public int Idcategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public bool? Estado { get; set; }

        public virtual ICollection<Subcategoria> Subcategoria { get; set; }
    }
}