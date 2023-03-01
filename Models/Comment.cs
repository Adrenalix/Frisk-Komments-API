namespace Frisk_API.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public string TextInput { get; set; }
        public int ReplyId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
