using Avtobus1DAL.Interfaces;
using Avtobus1DAL.Models;
using Avtobus1DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Avtobus1DAL.Repositories
{
    public class UrlRepository : IUrlRepository
    {
        private ApplicationContext _context;
        public UrlRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<UrlEntity> Get()
        {
            var urls = _context.UrlEntities.ToList();
            return urls;
        }
        public async Task<UrlEntity> GetItem(int id)
        {
            var url = _context.UrlEntities.FirstOrDefault(x => x.Id == id);
            return url;
        }
        public async Task Create(UrlEntity urlEntity)
        {   
            if(urlEntity != null)
            {
                _context.UrlEntities.Add(urlEntity);
                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("New Url Cannot be blanc!");
            }
        }
        public async Task Delete(int id)
        {
            var url =_context.UrlEntities.FirstOrDefault(x => x.Id == id); 
            _context.UrlEntities.Remove(url);
            _context.SaveChanges();
        }

        public async Task Edit(UrlEntity urlEntity)
        {
            _context.UrlEntities.Update(urlEntity);
            _context.SaveChanges();
        }
        public async Task Increment(int id)
        {
            var url = _context.UrlEntities.FirstOrDefault(x => x.Id == id);
            url.Counter+=1;
            _context.UrlEntities.Update(url);
            _context.SaveChanges();
        }
       
    }
}
