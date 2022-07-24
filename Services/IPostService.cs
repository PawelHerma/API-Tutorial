using API_Tutorial.Domain;

namespace API_Tutorial.Services
{
    public interface IPostService
    {
        public List<Post> GetPosts();
        public Post GetPostById(Guid postId);
        public bool UpdatePost(Post updatedPost);
    }
}
