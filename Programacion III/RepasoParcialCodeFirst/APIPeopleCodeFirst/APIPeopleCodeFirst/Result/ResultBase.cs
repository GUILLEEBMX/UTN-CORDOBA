using System.Net;

namespace APIPeopleCodeFirst.Result
{
    public class ResultBase
    {
        public string Error { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }


    }
}
