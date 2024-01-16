using DemoBasic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBasic.ViewModels
{
    public interface ICategorias : IModel<Categoria>
    {
        public Categoria SearchByName(string name);
    }
}
