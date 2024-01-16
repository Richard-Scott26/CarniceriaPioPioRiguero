using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBasic.ViewModels
{
    public interface IModel<T>
    {
        public int Create(T t);
        public List<T> Read();
        public int Update(T t);
        public int Delete(T t);
        public T Search(int id);
    }
}
