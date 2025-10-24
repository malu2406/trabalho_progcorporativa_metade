using trab1.Model;

namespace trab1.Repository
{
    public class MusicRepository : IMusicRepository
    {
        private readonly List<Music> _musics = new();

        public IEnumerable<Music> GetAll()
        {
            return _musics;
        }

        public Music? GetById(Guid id)
        {
            return _musics.FirstOrDefault(m => m.Id == id);
        }

        public void Add(Music music)
        {
            _musics.Add(music);
        }
    }
}