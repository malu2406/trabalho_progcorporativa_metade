using System.Dynamic;

namespace trab1.Model
{
    public class Channel
    {
        public Guid Id
        { 
            get; set;
        } = Guid.NewGuid();
        public required string Name
        {
            get; set;
        }
        public List<Music> Musics
        {
            get; set;
        } = [];

        public void CreateMusic(Music music)
        {
            this.Musics.Add(music);
        }

        public int Inscritos
        {
            get; set;
        }

        public DateOnly Data
        { 
            get; set; 
        }
    }
}