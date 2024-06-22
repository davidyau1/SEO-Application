using Newtonsoft.Json.Linq;
using SerpAPI.Models;
using SerpApi;
using System.Collections;

namespace SerpAPI
{
    public class SerpAPI
    {
        public List<OrganicResult> GetOrganicResults(GetSerp searchForm)
        {
            var data = GetSerpAPIData(searchForm);
            var res = FilterOrganicResults(data);
            return res;
        }

        private JObject GetSerpAPIData(GetSerp searchForm)
        {
            String apiKey = /*"test";//*/Environment.GetEnvironmentVariable("SerpAPIKey");//Must set SerpAPIKey in env variable
            var data= new JObject();

            Hashtable ht = new Hashtable();
            ht.Add("q", searchForm.KeyWord);
            ht.Add("hl", "en");
            ht.Add("num", searchForm.Limit.ToString());
            try
            {
                GoogleSearch search = new GoogleSearch(ht, apiKey);
                data = search.GetJson();

            }
            catch (Exception ex)
            {
                return new JObject();

            }
             return data;
        }   

        private List<OrganicResult> FilterOrganicResults(JObject data)
        {
            var res = new List<OrganicResult>();

            JArray results = (JArray)data["organic_results"];

            foreach (JObject result in results)
            {
                OrganicResult? organicResult = result.ToObject<OrganicResult>();
                if (organicResult != null)
                {
                    res.Add(organicResult);
                }
            }
            return res;
        }
      
    }
}
