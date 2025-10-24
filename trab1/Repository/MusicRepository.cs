using trab1.Model;
using trab1.Data;

namespace trab1.Repository
{
    public class MusicRepository : IMusicRepository
    {
        private readonly AppDbContext _context;

        public MusicRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Music> GetAll()
        {
            return _context.Musics.ToList(); // REMOVE todos os .Include
        }

        public Music? GetById(Guid id)
        {
            return _context.Musics.FirstOrDefault(m => m.Id == id); // REMOVE todos os .Include
        }

        public void Add(Music music)
        {
            _context.Musics.Add(music);
            _context.SaveChanges();
        }
    }
}