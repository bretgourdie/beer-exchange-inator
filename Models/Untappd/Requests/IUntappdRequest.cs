namespace Models.Untappd.Requests
{
    public interface IUntappdRequest
    {
        string GetEndpoint();
        string GetPayload();
    }
}
