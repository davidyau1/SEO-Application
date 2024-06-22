using Controllers.Models;
using SerpAPI.Models;
using SerpAPILibrary;
namespace Controllers
{
    public class SearchController:ISearchController
    {
        private ISerpAPI _serpAPI;
        public SearchController(ISerpAPI serpAPI)
        {
            _serpAPI = serpAPI;
        }
        public ResultForm GetSeoPostition(SearchForm searchForm)
        {
            var result = new ResultForm()
            {
                KeyWord = searchForm.KeyWord,
                Limit = searchForm.Limit,
                Url = searchForm.Url,
            };
            var serpAPIData = _serpAPI.GetOrganicResults(searchForm);
            if (serpAPIData == null)
            {
                result.Result = "";
            }
            var positions = ParseSerpAPIOrganicResults(serpAPIData, searchForm.Url);
            result.Result = string.Join(" ,", positions);

            return result;
        }

        private List<int> ParseSerpAPIOrganicResults(List<OrganicResult> organicResultsList, string searchURL)
        {
            var res = new List<int>();

            try
            {
                foreach (var organicResult in organicResultsList)
                {

                    if (organicResult.Link.Contains(searchURL))
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
