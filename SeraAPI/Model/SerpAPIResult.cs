using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeraAPI.Model
{
    public class OrganicResult
    {
        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("redirect_link")]
        public string RedirectLink { get; set; }

        [JsonProperty("displayed_link")]
        public string DisplayedLink { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("snippet_highlighted_words")]
        public List<string> SnippetHighlightedWords { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class OtherPages
    {
        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }

        [JsonProperty("5")]
        public string _5 { get; set; }
    }

    public class Pagination
    {
        [JsonProperty("current")]
        public int? Current { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("other_pages")]
        public OtherPages OtherPages { get; set; }
    }

    public class RelatedQuestion
    {
        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("displayed_link")]
        public string DisplayedLink { get; set; }

        [JsonProperty("next_page_token")]
        public string NextPageToken { get; set; }

        [JsonProperty("serpapi_link")]
        public string SerpapiLink { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("source_logo")]
        public string SourceLogo { get; set; }
    }

    public class RelatedSearch
    {
        [JsonProperty("block_position")]
        public int? BlockPosition { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("serpapi_link")]
        public string SerpapiLink { get; set; }
    }

    public class Root
    {
        [JsonProperty("search_metadata")]
        public SearchMetadata SearchMetadata { get; set; }

        [JsonProperty("search_parameters")]
        public SearchParameters SearchParameters { get; set; }

        [JsonProperty("search_information")]
        public SearchInformation SearchInformation { get; set; }

        [JsonProperty("related_questions")]
        public List<RelatedQuestion> RelatedQuestions { get; set; }

        [JsonProperty("organic_results")]
        public List<OrganicResult> OrganicResults { get; set; }

        [JsonProperty("related_searches")]
        public List<RelatedSearch> RelatedSearches { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("serpapi_pagination")]
        public SerpapiPagination SerpapiPagination { get; set; }
    }

    public class SearchInformation
    {
        [JsonProperty("query_displayed")]
        public string QueryDisplayed { get; set; }

        [JsonProperty("total_results")]
        public int? TotalResults { get; set; }

        [JsonProperty("time_taken_displayed")]
        public double? TimeTakenDisplayed { get; set; }

        [JsonProperty("organic_results_state")]
        public string OrganicResultsState { get; set; }
    }

    public class SearchMetadata
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("json_endpoint")]
        public string JsonEndpoint { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("processed_at")]
        public string ProcessedAt { get; set; }

        [JsonProperty("google_url")]
        public string GoogleUrl { get; set; }

        [JsonProperty("raw_html_file")]
        public string RawHtmlFile { get; set; }

        [JsonProperty("total_time_taken")]
        public double? TotalTimeTaken { get; set; }
    }

    public class SearchParameters
    {
        [JsonProperty("engine")]
        public string Engine { get; set; }

        [JsonProperty("q")]
        public string Q { get; set; }

        [JsonProperty("location_requested")]
        public string LocationRequested { get; set; }

        [JsonProperty("location_used")]
        public string LocationUsed { get; set; }

        [JsonProperty("google_domain")]
        public string GoogleDomain { get; set; }

        [JsonProperty("hl")]
        public string Hl { get; set; }

        [JsonProperty("gl")]
        public string Gl { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }
    }

    public class SerpapiPagination
    {
        [JsonProperty("current")]
        public int? Current { get; set; }

        [JsonProperty("next_link")]
        public string NextLink { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("other_pages")]
        public OtherPages OtherPages { get; set; }
    }

}
