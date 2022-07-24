using API_Tutorial.Domain;

namespace API_Tutorial.Services
{
    public interface IPostService
    {
        public Task<List<Post>> GetPostsAsync();
        public Task<Post> GetPostByIdAsync(Guid postId);
        public Task<bool> CreatePostAsync(Post post);
        public Task<bool> UpdatePostAsync(Post updatedPost);
        public Task<bool> DeletePostAsync(Guid postId);
    }
}
