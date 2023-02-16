namespace Frisk_API.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderUserId { get; set; }
        public int RecieverUserId { get; set; }
        public string TextInput { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
