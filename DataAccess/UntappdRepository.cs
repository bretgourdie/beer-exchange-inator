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
        private readonly UntappdAuthenticator _untappdAuthenticator;

        public UntappdRepository()
        {
            _restClient = new RestClient(endpointBase);
            _untappdAuthenticator = new UntappdAuthenticator();
        }
    }
}
