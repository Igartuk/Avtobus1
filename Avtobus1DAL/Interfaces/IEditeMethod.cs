using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtobus1DAL.Interfaces
{
    public interface IEditMethod<T> where T : class
    {
        public Task Edit(T item);
    }

}
