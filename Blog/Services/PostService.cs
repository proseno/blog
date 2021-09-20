using System.Collections.Generic;
using Blog.Models;
using MongoDB.Driver;

namespace Blog.Services
{
    public class PostService
    {
        private readonly IMongoCollection<Post> _posts;
        
        public PostService(IBlogDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _posts = database.GetCollection<Post>(settings.BlogCollectionName);
        }

        public List<Post> Get() =>
            _posts.Find(post => true).ToList();

        public Post Get(string id) =>
            _posts.Find<Post>(post => post.Id == id).FirstOrDefault();

        public Post Create(Post post)
        {
            _posts.InsertOne(post);
            return post;
        }

        public void Update(string id, Post bookIn) =>
            _posts.ReplaceOne(post => post.Id == id, bookIn);

        public void Remove(Post postIn) =>
            _posts.DeleteOne(post => post.Id == postIn.Id);

        public void Remove(string id) => 
            _posts.DeleteOne(post => post.Id == id);
    }
}