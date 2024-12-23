namespace MyBlog.Domain.Interfaces;

using Models;

public interface IPostRepository
{
  Task<IEnumerable<Post>> GetAllAsync();
  Task<Post?> GetByIdAsync( int id );
  Task AddAsync( Post post );
  Task DeleteAsync(int id);
  Task UpdateAsync(Post post);
}
