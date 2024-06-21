using Newtonsoft.Json.Linq;
using SerpApi;
using SerpAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpAPI
{
    public class GetSerpApi
    {
        public List<OrganicResult> GetSerpAPIOrganicResults(SearchForm searchForm)
        {
            var res=new List<OrganicResult>();
            String apiKey = Environment.GetEnvironmentVariable("SerpAPIKey");//Must set SerpAPIKey in env variable

            Hashtable ht = new Hashtable();
            ht.Add("q", searchForm.KeyWord);
            ht.Add("location", "Austin, Texas, United States");
            ht.Add("hl", "en");
            ht.Add("gl", "us");
            ht.Add("google_domain", "google.com");
            ht.Add("num", searchForm.Limit);
            try
            {
                GoogleSearch search = new GoogleSearch(ht, apiKey);
                JObject data = search.GetJson();
                JArray results = (JArray)data["organic_results"];

        
                foreach (JObject result in results)
                {
                    OrganicResult? organicResult= result.ToObject<OrganicResult>();
                    if (organicResult != null) {
                        res.Add(organicResult);
                    }
                }
            }
            catch (SerpApiSearchException ex)
            {
                Console.WriteLine("Exception:");
                Console.WriteLine(ex.ToString());
            }
            return res;




        }
    } 
}
