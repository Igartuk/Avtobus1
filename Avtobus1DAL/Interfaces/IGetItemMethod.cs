using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtobus1DAL.Interfaces
{
    public interface IGetItemMethod<T> where T : class
    {
        public Task<T> GetItem(int id);
    }
}
