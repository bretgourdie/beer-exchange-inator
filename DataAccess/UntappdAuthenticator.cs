using RestSharp;

namespace DataAccess
{
    internal class UntappdAuthenticator
    {
        IUntappdAuthenticationStrategy untappdAuthenticationStrategy;

        public void AddAuthentication(IRestRequest request)
        {
            untappdAuthenticationStrategy = untappdAuthenticationStrategy.HandleState();
            untappdAuthenticationStrategy.AddAuthentication(request);
        }
    }
}
