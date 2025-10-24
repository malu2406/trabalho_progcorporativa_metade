using trab1.Model;
using trab1.Data;

namespace trab1.Repository
{
    public class ChannelRepository : IChannelRepository
    {
        private readonly AppDbContext _context;

        public ChannelRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Channel> GetAll()
        {
            return _context.Channels.ToList(); // REMOVE .Include(c => c.Musics)
        }

        public Channel? GetById(Guid id)
        {
            return _context.Channels.FirstOrDefault(c => c.Id == id); // REMOVE .Include(c => c.Musics)
        }

        public void Add(Channel channel)
        {
            _context.Channels.Add(channel);
            _context.SaveChanges();
        }
    }
}