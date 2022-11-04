
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtobus1DAL.Models.Entities
{
    public class UrlEntity
    {
        public int Id { get; set; }
        [Url]
        public string LongUrl { get; set; }
        [Url]
        public string ShortUrl { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public int Counter { get; set; } = 0;
    }
}
