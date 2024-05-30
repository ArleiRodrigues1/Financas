using System.Text.Json.Serialization;

namespace Fina.Core.Responses
{
    public class Response<TData>
    {

        [JsonConstructor]
        public Response() => _code = Configuration.DefaultStatusCode;

        public Response(TData? data, int Code = 200, string? message = null)
        {
            Data = data;
            _code = Code;
            Message = message;
        }
        private int _code = Configuration.DefaultStatusCode;

        public TData? Data { get; set; }
        public string? Message { get; set; }

        [JsonIgnore]
        public bool IsSuccess => _code is >= 200 and <= 299;
    }
}