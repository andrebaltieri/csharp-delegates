namespace DelegatesSample.Models
{
    public class ErrorModel
    {
        public ErrorModel()
        {
        }

        public ErrorModel(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}