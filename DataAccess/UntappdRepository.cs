using RestSharp;
using System;

namespace DataAccess
{
    public class UntappdRepository
    {
        private const string authenticationBase =
            @"https://untappd.com/oauth/authenticate/?client_id=CLIENTID&response_type=code&redirect_url=REDIRECT_URL";
        private const int callsPerHour = 100;
        private const string endpointBase = @"https://api.untappd.com/";

        private readonly RestClient _restClient;

        public UntappdRepository()
        {
            _restClient = new RestClient(endpointBase);
        }

        public void Authenticate()
        {
            throw new NotImplementedException();
        }
    }
}
