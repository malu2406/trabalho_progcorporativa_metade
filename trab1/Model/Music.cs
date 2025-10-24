namespace trab1.Model
{
    public record class Music
    {
        public required string Title
        {
            get; set;
        }

        public Guid Id
        {
            get; set;
        }

        public required Channel Channel
        {
            get; set;
        }
        public List<Comment> Commentaries
        {
            get; set;
        } = [];
        
    }
}