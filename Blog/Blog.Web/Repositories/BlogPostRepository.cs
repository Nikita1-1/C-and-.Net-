using Blog.Web.Data;
using Blog.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly BlogDBContext blogDBContext;

        public BlogPostRepository(BlogDBContext blogDBContext)
        {
            this.blogDBContext = blogDBContext;
        }
        public async Task<BlogPost> AddAsync(BlogPost blogPosts)
        {
            await blogDBContext.AddAsync(blogPosts);
            await blogDBContext.SaveChangesAsync();
            return blogPosts;
        }

        public Task<BlogPost?> DeleteAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BlogPost>> GetAllAsync()
        {
            return await blogDBContext.BlogPosts.Include(x => x.Tags).ToListAsync();
        }

        public Task<BlogPost?> GetAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<BlogPost?> UpdateAsync(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }
    }
}
