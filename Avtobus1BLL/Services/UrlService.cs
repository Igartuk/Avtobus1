using AutoMapper;
using Avtobus1BLL.DTOs;
using Avtobus1BLL.Helpers;
using Avtobus1BLL.Interfaces;
using Avtobus1DAL.Interfaces;
using Avtobus1DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtobus1BLL.Services
{
    public class UrlService : IUrlService

    {
        private readonly IUrlRepository _urlRepository;
        private readonly IMapper _mapper;
        public UrlService(IUrlRepository urlRepository,IMapper mapper)
        {
            _mapper = mapper;
            _urlRepository = urlRepository;
        }

        public async Task<IEnumerable<UrlElementDTO>> Get()
        {
            var urls = _urlRepository.Get();
            var urlElementDTOs = _mapper.Map<IEnumerable<UrlElementDTO>>(urls);
            return urlElementDTOs;
        }
        public async Task<UrlElementDTO> GetItem(int id)
        {
            var url = await _urlRepository.GetItem(id);
            var urlElementDTO = _mapper.Map<UrlElementDTO>(url);
            
            return urlElementDTO;
        }
        public async Task Create(CreateUrlDTO createUrlDTO)
        {
            ShortUrlHelper shortenner = new ShortUrlHelper(createUrlDTO);
            shortenner.GetUrl();
            
            var url = _mapper.Map<UrlEntity>(createUrlDTO);
            await _urlRepository.Create(url);
        }
        public async Task Edit(CreateUrlDTO createUrlDTO)
        {
            var url = _mapper.Map<UrlEntity>(createUrlDTO);
            await _urlRepository.Edit(url);
        }

        public Task Delete(int id) => _urlRepository.Delete(id);
        public Task Increment(int id) => _urlRepository.Increment(id);
    }
}
