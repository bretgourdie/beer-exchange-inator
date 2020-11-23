using Models.Untappd.Core;

namespace Models.Untappd.Responses
{
    class BeerSearchResponse
    {
        public int found { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public string term { get; set; }
        public string parsed_term { get; set; }
        public Beers beers { get; set; }
        public Homebrew homebrew { get; set; }
        public Breweries breweries { get; set; }
    }
}
