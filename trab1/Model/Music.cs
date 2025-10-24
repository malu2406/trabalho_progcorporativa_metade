namespace trab1.Model
{
    public class Music
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Title { get; set; }
        public Guid ChannelId { get; set; }
        // REMOVA estas linhas:
        // public virtual Channel Channel { get; set; } = null!;
        // public virtual ICollection<Comment> Commentaries { get; set; } = new List<Comment>();
    }
}