namespace Frisk_API.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int RecieverId { get; set; }
        public string TextInput { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
