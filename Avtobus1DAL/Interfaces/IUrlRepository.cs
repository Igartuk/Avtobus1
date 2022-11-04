using Avtobus1DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtobus1DAL.Interfaces
{
    public interface IUrlRepository :
            IGetListMethod<UrlEntity>,
            IGetItemMethod<UrlEntity>,
            IEditMethod<UrlEntity>,
            ICreateMethod<UrlEntity>,
            IDeleteMethod<UrlEntity>
    {
        public Task Increment(int id);
    }
}
