using API_Tutorial.Domain;

namespace API_Tutorial.Services
{
    public class PostService : IPostService
    {
        private List<Post> _posts;
        public PostService()
        {
            _posts = new List<Post>();
            for (var i = 0; i < 5; i++)
            {
                _posts.Add(new Post 
                { 
                    Id = Guid.NewGuid(),
                    Name = i.ToString(),
                });
            }
        }
        public Post GetPostById(Guid postId)
        {
            return _posts.SingleOrDefault(x=>x.Id == postId);
        }

        public List<Post> GetPosts()
        {
            return _posts;
        }
    }
}
