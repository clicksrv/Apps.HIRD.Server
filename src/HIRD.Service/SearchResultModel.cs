using Newtonsoft.Json;

namespace HIRD.Service
{
    public class Url
    {
        [JsonConstructor]
        public Url(
            string type,
            string template
        )
        {
            this.Type = type;
            this.Template = template;
        }

        public string Type { get; }
        public string Template { get; }
    }

    public class Request
    {
        [JsonConstructor]
        public Request(
            string title,
            string totalResults,
            string searchTerms,
            int count,
            int startIndex,
            string inputEncoding,
            string outputEncoding,
            string safe,
            string cx
        )
        {
            this.Title = title;
            this.TotalResults = totalResults;
            this.SearchTerms = searchTerms;
            this.Count = count;
            this.StartIndex = startIndex;
            this.InputEncoding = inputEncoding;
            this.OutputEncoding = outputEncoding;
            this.Safe = safe;
            this.Cx = cx;
        }

        public string Title { get; }
        public string TotalResults { get; }
        public string SearchTerms { get; }
        public int Count { get; }
        public int StartIndex { get; }
        public string InputEncoding { get; }
        public string OutputEncoding { get; }
        public string Safe { get; }
        public string Cx { get; }
    }

    public class NextPage
    {
        [JsonConstructor]
        public NextPage(
            string title,
            string totalResults,
            string searchTerms,
            int count,
            int startIndex,
            string inputEncoding,
            string outputEncoding,
            string safe,
            string cx
        )
        {
            this.Title = title;
            this.TotalResults = totalResults;
            this.SearchTerms = searchTerms;
            this.Count = count;
            this.StartIndex = startIndex;
            this.InputEncoding = inputEncoding;
            this.OutputEncoding = outputEncoding;
            this.Safe = safe;
            this.Cx = cx;
        }

        public string Title { get; }
        public string TotalResults { get; }
        public string SearchTerms { get; }
        public int Count { get; }
        public int StartIndex { get; }
        public string InputEncoding { get; }
        public string OutputEncoding { get; }
        public string Safe { get; }
        public string Cx { get; }
    }

    public class Queries
    {
        [JsonConstructor]
        public Queries(
            List<Request> request,
            List<NextPage> nextPage
        )
        {
            this.Request = request;
            this.NextPage = nextPage;
        }

        public IReadOnlyList<Request> Request { get; }
        public IReadOnlyList<NextPage> NextPage { get; }
    }

    public class Context
    {
        [JsonConstructor]
        public Context(
            string title
        )
        {
            this.Title = title;
        }

        public string Title { get; }
    }

    public class SearchInformation
    {
        [JsonConstructor]
        public SearchInformation(
            double searchTime,
            string formattedSearchTime,
            string totalResults,
            string formattedTotalResults
        )
        {
            this.SearchTime = searchTime;
            this.FormattedSearchTime = formattedSearchTime;
            this.TotalResults = totalResults;
            this.FormattedTotalResults = formattedTotalResults;
        }

        public double SearchTime { get; }
        public string FormattedSearchTime { get; }
        public string TotalResults { get; }
        public string FormattedTotalResults { get; }
    }

    public class Scraped
    {
        [JsonConstructor]
        public Scraped(
            string imageLink
        )
        {
            this.ImageLink = imageLink;
        }

        public string ImageLink { get; }
    }

    public class CseThumbnail
    {
        [JsonConstructor]
        public CseThumbnail(
            string src,
            string width,
            string height
        )
        {
            this.Src = src;
            this.Width = width;
            this.Height = height;
        }

        public string Src { get; }
        public string Width { get; }
        public string Height { get; }
    }

    public class Metatag
    {
        [JsonConstructor]
        public Metatag(
            [JsonProperty("og:image")] string ogImage,
            [JsonProperty("og:title")] string ogTitle,
            [JsonProperty("og:url")] string ogUrl,
            string title,
            [JsonProperty("og:description")] string ogDescription
        )
        {
            this.OgImage = ogImage;
            this.OgTitle = ogTitle;
            this.OgUrl = ogUrl;
            this.Title = title;
            this.OgDescription = ogDescription;
        }

        [JsonProperty("og:image")]
        public string OgImage { get; }

        [JsonProperty("og:title")]
        public string OgTitle { get; }

        [JsonProperty("og:url")]
        public string OgUrl { get; }
        public string Title { get; }

        [JsonProperty("og:description")]
        public string OgDescription { get; }
    }

    public class CseImage
    {
        [JsonConstructor]
        public CseImage(
            string src
        )
        {
            this.Src = src;
        }

        public string Src { get; }
    }

    public class Pagemap
    {
        [JsonConstructor]
        public Pagemap(
            List<Scraped> scraped,
            List<CseThumbnail> cseThumbnail,
            List<Metatag> metatags,
            List<CseImage> cseImage
        )
        {
            this.Scraped = scraped;
            this.CseThumbnail = cseThumbnail;
            this.Metatags = metatags;
            this.CseImage = cseImage;
        }

        public IReadOnlyList<Scraped> Scraped { get; }
        public IReadOnlyList<CseThumbnail> CseThumbnail { get; }
        public IReadOnlyList<Metatag> Metatags { get; }
        public IReadOnlyList<CseImage> CseImage { get; }
    }

    public class Item
    {
        [JsonConstructor]
        public Item(
            string kind,
            string title,
            string htmlTitle,
            string link,
            string displayLink,
            string snippet,
            string htmlSnippet,
            string cacheId,
            string formattedUrl,
            string htmlFormattedUrl,
            Pagemap pagemap
        )
        {
            this.Kind = kind;
            this.Title = title;
            this.HtmlTitle = htmlTitle;
            this.Link = link;
            this.DisplayLink = displayLink;
            this.Snippet = snippet;
            this.HtmlSnippet = htmlSnippet;
            this.CacheId = cacheId;
            this.FormattedUrl = formattedUrl;
            this.HtmlFormattedUrl = htmlFormattedUrl;
            this.Pagemap = pagemap;
        }

        public string Kind { get; }
        public string Title { get; }
        public string HtmlTitle { get; }
        public string Link { get; }
        public string DisplayLink { get; }
        public string Snippet { get; }
        public string HtmlSnippet { get; }
        public string CacheId { get; }
        public string FormattedUrl { get; }
        public string HtmlFormattedUrl { get; }
        public Pagemap Pagemap { get; }
    }

    public class SearchResultModel
    {
        [JsonConstructor]
        public SearchResultModel(
            string kind,
            Url url,
            Queries queries,
            Context context,
            SearchInformation searchInformation,
            List<Item> items
        )
        {
            this.Kind = kind;
            this.Url = url;
            this.Queries = queries;
            this.Context = context;
            this.SearchInformation = searchInformation;
            this.Items = items;
        }

        public string Kind { get; }
        public Url Url { get; }
        public Queries Queries { get; }
        public Context Context { get; }
        public SearchInformation SearchInformation { get; }
        public IReadOnlyList<Item> Items { get; }
    }
}
