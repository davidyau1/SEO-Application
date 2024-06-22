namespace Controllers.Models
{
    public class SearchForm : SerpAPILibrary.Models.GetSerp
    {
        public string Url { get; set; }

        public SearchForm(string keyWord, string url, int limit = 100)
        {
            KeyWord = keyWord;
            Url = url;
            Limit = limit + 1;// need to add one as SerpApi stops at one less

        }

    }
}
