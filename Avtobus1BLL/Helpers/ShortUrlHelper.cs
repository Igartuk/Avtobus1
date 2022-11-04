using Avtobus1BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtobus1BLL.Helpers
{
    public class ShortUrlHelper
    {
        private readonly CreateUrlDTO _createUrlDTO;

        public ShortUrlHelper(CreateUrlDTO createUrlDTO) 
        {
            _createUrlDTO = createUrlDTO;
        }
        public CreateUrlDTO GetUrl()
        {
            string shortened = GetShortUrl(_createUrlDTO.LongUrl);
            _createUrlDTO.ShortUrl = $"https://avtobus1/{shortened}";
            return _createUrlDTO;
        }
        public string GetShortUrl(string longUrl)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[4];
            for(int i= 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[new Random().Next(chars.Length)];
            }
            var finalString = new string(stringChars);
            return finalString;
        }

    }
}
