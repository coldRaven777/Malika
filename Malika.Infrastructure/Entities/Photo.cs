namespace Malika.Infrastructure.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public byte[] PhotoData { get; set; }
        public Person Person { get; set; }
        public DateTime CreatedTime { get; set; }

    }
}
