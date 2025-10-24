using trab1.Model;

namespace trab1.Repository
{
    public class ChannelRepository : IChannelRepository
    {
        private readonly List<Channel> _channels = new();

        public IEnumerable<Channel> GetAll()
        {
            return _channels;
        }

        public Channel? GetById(Guid id)
        {
            return _channels.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Channel channel)
        {
            _channels.Add(channel);
        }
    }
}

