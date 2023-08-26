using System.Net;

namespace API_ParcialTurnoTarde.Result
{
    public class ResultBase
    {

        public string Message { get; set; }
        public bool Error { get; set; }
        public HttpStatusCode StatusCode { get; set; }

    }
}
