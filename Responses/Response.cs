using Flunt.Notifications;

namespace DelegatesSample.Responses
{
    public class Response<T> : Notifiable<Notification>
    {
        public Response()
        {
        }

        public Response(T data)
        {
            Status = 200;
            Data = data;
        }

        public string Message { get; set; }
        public int Status { get; set; }
        public T Data { get; set; }
    }
}