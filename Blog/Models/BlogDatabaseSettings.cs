namespace Blog.Models
{
    public class BlogDatabaseSettings : IBlogDatabaseSettings
    {
        public string BlogCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IBlogDatabaseSettings
    {
        string BlogCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}