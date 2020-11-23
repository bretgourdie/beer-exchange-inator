using Models.Untappd.Core;
using System.Collections.Generic;

namespace Models.Untappd.Responses
{
    public class BrewerySearchResponse
    {
        public int found { get; set; }
        public List<Brewery> brewery { get; set; }
    }
}
