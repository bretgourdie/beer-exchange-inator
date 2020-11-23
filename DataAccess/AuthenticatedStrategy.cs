using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace DataAccess
{
    internal class AuthenticatedStrategy : IUntappdAuthenticationStrategy
    {
        private readonly string access_token;

        public AuthenticatedStrategy(string accessToken)
        {
            access_token = accessToken;
        }

        public void AddAuthentication(IRestRequest request)
        {
            request.AddParameter(
                nameof(access_token),
                access_token);
        }

        public IUntappdAuthenticationStrategy HandleState()
        {
            return this;
        }
    }
}
