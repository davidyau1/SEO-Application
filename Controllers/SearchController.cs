using Controllers.Models;
using SerpAPI;
using SerpAPI.Models;
using Controllers.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class SearchController
    {
        private SerpAPI.SerpAPI _serpAPI;
        public SearchController()
        {
            _serpAPI = new SerpAPI.SerpAPI();
        }
        public ResultForm GetSeoPostition(SearchForm searchForm)
        {
            var result = new ResultForm()
            {
                KeyWord = searchForm.KeyWord,
                Limit = searchForm.Limit,
                Url = searchForm.Url,
            };
            var serpAPIData = _serpAPI.GetOrganicResults((GetSerp)searchForm);
            if (serpAPIData == null)
            {
                result.Result = "";
            }
            var positions = ParseSerpAPIOrganicResults(serpAPIData, searchForm.Url);
            result.Result = string.Join(" ,", positions);

            return result;
        }

        public List<int> ParseSerpAPIOrganicResults(List<OrganicResult> organicResultsList, string searchURL)
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
