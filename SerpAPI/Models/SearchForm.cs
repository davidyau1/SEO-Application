using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpAPI.Models
{
    public class SearchForm
    {
        public string KeyWord { get; set; } 
        public string Url { get; set; }
        public int? Limit { get; set; }

    }
}
