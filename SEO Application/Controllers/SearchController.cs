using SerpAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEO_Application.Controllers
{
    internal class SearchController
    {
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
