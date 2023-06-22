using System.Net;

namespace FirstProjectProgramacionIII.ResultModel
{
    public class Result<T>
    {
        public List<T> Values { get; set; }
        public bool Success { get; set; }

        public string Error { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public void SetMessageError(string messageError, HttpStatusCode statusCode)
        {
            this.Error = messageError;
            this.StatusCode = statusCode;

        }


    }
}
