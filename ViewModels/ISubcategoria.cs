using DemoBasic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBasic.ViewModels
{
    public interface ISubcategoria : IModel<Subcategoria>
    {
        public Subcategoria SearchByName(string name);
        public List<Subcategoria> SearchByCategory(string categoryName);
    }
}
