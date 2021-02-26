namespace DelegatesSample.Models
{
    public class ArticleModel
    {
        public ArticleModel()
        {
            
        }

        public ArticleModel(int id, string title)
        {
            Id = id;
            Title = title;
        }
        
        public int Id { get; set; }
        public string Title { get; set; }
    }
}