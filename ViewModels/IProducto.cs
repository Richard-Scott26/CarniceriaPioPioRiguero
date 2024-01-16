using DemoBasic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBasic.ViewModels
{
    public interface IProducto : IModel<Producto>
    {
        public Producto SearchByCodigo(string code);
        public Producto SearchByProductNumber(string productNumber);
        public List<Producto> SearchByName(string name);
        public List<Producto> SearchByCategory(string categoryName);
        public List<Producto> SearchBySubcategoryName(string subcategoryName);
    }
}
