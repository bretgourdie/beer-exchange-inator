using System;

namespace Models.Untappd.Requests
{
    public class BeerSearch : IUntappdRequest
    {
        /// <summary>
        /// The search term that you want to search.
        /// </summary>
        public string q { get; set; }

        /// <summary>
        /// The numeric offset that you want results to start.
        /// </summary>
        public int? offset { get; set; }

        /// <summary>
        /// The number of results to return, max of 50, default is 25.
        /// </summary>
        public int? limit { get; set; }

        public Sort sort { get; set; }

        public string GetEndpoint()
        {
            return "/v4/search/beer";
        }

        public string GetPayload()
        {
            throw new NotImplementedException();
        }

        public enum Sort
        {
            CheckIn,
            Name
        }
    }
}
