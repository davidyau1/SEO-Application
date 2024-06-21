using SEO_Application.Models;
using SerpAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEO_Application.Controllers
{
    public class SearchController
    {
        //private SerpAPI _serpAPI;
        public string GetSeoPostition (SearchForm searchForm){
            var serpAPIData = new List<OrganicResult>(); //_serpAPI.GetSerpAPIOrganicResults(searchForm);
            var positions= ParseSerpAPIOrganicResults(serpAPIData, searchForm.Url);
            return string.Join(" ,", positions);


        }

        private List<int> ParseSerpAPIOrganicResults(List<OrganicResult> organicResultsList, string searchURL)
        {
            var res = new List<int>();

            try
            {
                foreach (var organicResult in organicResultsList)
                {
                    if (organicResult?.Link == searchURL)
                    {
                        res.Add(organicResult.Position.GetValueOrDefault());
                    }
                }
                if (res.Count == 0)
                {
                    res.Add(0);
                }
                return res;

            }

            catch (Exception)
            {
                return res;

            }


        }

    }
}
