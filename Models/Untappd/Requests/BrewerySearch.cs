using System;

namespace Models.Untappd.Requests
{
    public class BrewerySearch : IUntappdRequest
    {
        public string q { get; set; }
        public int? offset { get; set; }
        public int? limit { get; set; }

        public string GetEndpoint()
        {
            return "/v4/search/brewery";
        }

        public string GetPayload()
        {
            throw new NotImplementedException();
        }
    }
}
