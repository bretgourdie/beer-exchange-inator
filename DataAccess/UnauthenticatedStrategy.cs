using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class UnauthenticatedStrategy : IUntappdAuthenticationStrategy
    {
        private const string client_id = @"CLIENTID";
        private const string client_secret = @"CLIENTSECRET";

        private string accessToken;

        public void AddAuthentication(IRestRequest request)
        {
            addClientId(request);
            addClientSecret(request);
        }

        public IUntappdAuthenticationStrategy HandleState()
        {
            if (wasSuccessfulAuthentication())
            {
                return new AuthenticatedStrategy(accessToken);
            }

            return this;
        }

        private bool wasSuccessfulAuthentication()
        {
            return !string.IsNullOrEmpty(accessToken);
        }

        private void addClientId(IRestRequest request)
        {
            request.AddParameter(
                nameof(client_id),
                client_id);
        }

        private void addClientSecret(IRestRequest request)
        {
            request.AddParameter(
                nameof(client_secret),
                client_secret);
        }
    }
}
