using RestSharp;

namespace DataAccess
{
    internal interface IUntappdAuthenticationStrategy
    {
        void AddAuthentication(IRestRequest request);
        IUntappdAuthenticationStrategy HandleState();
    }
}
