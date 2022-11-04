using Avtobus1BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtobus1BLL.Interfaces
{
    public interface IUrlService
    {
        public Task<IEnumerable<UrlElementDTO>> Get();
        public Task<UrlElementDTO> GetItem(int id);
        public Task Create(CreateUrlDTO item);
        public Task Edit(CreateUrlDTO item);
        public Task Delete(int id);
        public Task Increment(int id);
    }
}
