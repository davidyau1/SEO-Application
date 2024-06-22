using Newtonsoft.Json;

namespace SerpAPI.Models
{
    public class OrganicResult
    {
        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("displayed_link")]
        public string DisplayedLink { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("cached_page_link")]
        public string CachedPageLink { get; set; }

        [JsonProperty("related_pages_link")]
        public string RelatedPagesLink { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("displayed_results")]
        public string DisplayedResults { get; set; }


    }
}
