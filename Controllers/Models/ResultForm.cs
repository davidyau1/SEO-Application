using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Models
{
    public class ResultForm
    {
        public string Result { get; set; }
        public string KeyWord { get; set; }
        public string Url { get; set; }
        public int Limit { get; set; }

        public ResultForm()
        {
                
        }
        public ResultForm(SearchForm searchForm)
        {
            Result = "Searching";
            KeyWord = searchForm.KeyWord;
            Url = searchForm.Url;
            Limit = searchForm.Limit;
        }
    }
    
}
