using API_Tutorial.Data;
using API_Tutorial.Domain;
using Microsoft.EntityFrameworkCore;

namespace API_Tutorial.Services
{
    public class PostService : IPostService
    {
        public readonly DataContext _dataContext;

        public PostService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task<Post> GetPostByIdAsync(Guid postId)
        {
            return await _dataContext.Post.SingleOrDefaultAsync(x=>x.Id == postId);
        }

        public async Task<List<Post>> GetPostsAsync()
        {
            return await _dataContext.Post.ToListAsync();
        }

        public async Task<bool> CreatePostAsync(Post post)
        {
            _dataContext.Post.AddAsync(post);
            var created = await _dataContext.SaveChangesAsync();
            return created > 0;
        }

        public async Task<bool> UpdatePostAsync(Post postToUpdate)
        {
            _dataContext.Post.Update(postToUpdate);
            var updated = await _dataContext.SaveChangesAsync();
            return updated > 0;
        }
        public async Task<bool> DeletePostAsync(Guid postId)
        {
            var post = await GetPostByIdAsync(postId);
            if(post == null)
                return false;
            _dataContext.Post.Remove(post);
            var deleted = await _dataContext.SaveChangesAsync();
            return deleted > 0;

        }
    }
}
