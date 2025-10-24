using trab1.Model;

namespace trab1.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly List<Comment> _comments = new();

        public IEnumerable<Comment> GetAll()
        {
            return _comments;
        }

        public Comment? GetById(Guid id)
        {
            return _comments.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Comment comment)
        {
            _comments.Add(comment);
        }
    }
}