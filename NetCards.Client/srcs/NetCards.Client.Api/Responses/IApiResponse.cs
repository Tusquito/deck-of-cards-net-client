using System.Net;

namespace NetCards.Client.Api.Responses
{
    /// <summary>
    /// Useful properties common to any API call response
    /// </summary>
    public interface IApiResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public string ResponseMessage { get; set; }
    }
}