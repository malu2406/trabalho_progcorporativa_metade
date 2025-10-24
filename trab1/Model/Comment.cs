namespace trab1.Model
{
    public record class Comment
    {
    public string? Text
        {
            get; set;
        }
        public Guid Id
        {
            get; set;
        }

        public required bool Liked
        {
            get; set;
        }

        public DateTime Date = DateTime.Now; 
    }
}