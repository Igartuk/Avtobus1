using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtobus1BLL.DTOs
{
    public class CreateUrlDTO
    {
        public int Id { get; set; }
        [Required]
        [Url]
        public string LongUrl { get; set; }
        public string ShortUrl { get; set; }
    }
}
