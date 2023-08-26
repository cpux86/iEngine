using System.Text.Json.Serialization;

namespace Api.Wrappers
{
    public class Response<T>
    {
        public Response(T data, string message)
        {
            Succeeded = true;
            this.Message = message;
            this.Data = data;
        }
        public Response(string message, T data)
        {
            Succeeded = false;
            this.Message = message;
            this.Data = data;
        }

        public Response(T data)
        {
            this.Data = data;
            Succeeded = true;
            Message = "succeeded";
        }

        public Response()
        {

        }
        [JsonPropertyName("succeeded")]
        public bool Succeeded { get; set; }

        [JsonPropertyName("message")] 
        public string Message { get; set; } = null!;

        [JsonPropertyName("data")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public T Data { get; set; } = default!;
    }
}
