﻿using Newtonsoft.Json.Linq;
using SerpAPILibrary.Models;
using SerpApi;
using System.Collections;
using SerpAPILibrary;

namespace SerpAPILibrary
{
    public class SerpAPI:ISerpAPI
    {
        public SerpAPI()
        {
                
        }

        public List<OrganicResult> GetOrganicResults(GetSerp searchForm)
        {
            var data = GetSerpAPIData(searchForm);
            var res = SerpAPIToOrganicResults(data);
            return res;
        }

        private JObject GetSerpAPIData(GetSerp searchForm)
        {   //Must set SerpAPIKey in env variable
            String apiKey = Environment.GetEnvironmentVariable("SerpAPIKey");
            var data = new JObject();

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

        public List<OrganicResult> SerpAPIToOrganicResults(JObject data)
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
