using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtobus1BLL.DTOs
{
    public class UrlElementDTO
    {
        public int Id { get; set; }
        [Url]
        public string LongUrl { get; set; }
        [Url]
        public string ShortUrl { get; set; }
        public DateTime CreateDate { get; set; }
        public int Counter { get; set; }
    }
}
