using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtobus1DAL.Interfaces
{
    public interface IDeleteMethod<T> where T : class
    {
        public Task Delete(int id);
    }
}
