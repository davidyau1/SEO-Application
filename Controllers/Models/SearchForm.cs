using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Models
{
    public class SearchForm : SerpAPI.Models.GetSerp
    {
        public string Url { get; set; }

        public SearchForm(string keyWord, string url, int limit = 100)
        {
            KeyWord = keyWord;
            Url = url;
            Limit = limit + 1;// need to add one as SerpApi stops at one less

        }

    }
}
