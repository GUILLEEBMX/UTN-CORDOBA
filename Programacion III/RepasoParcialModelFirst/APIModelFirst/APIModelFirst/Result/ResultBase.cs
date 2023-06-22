using System.Net;

namespace APIModelFirst.Result
{
    public class ResultBase
    {
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public bool Error { get; set; }
    }

  
}
