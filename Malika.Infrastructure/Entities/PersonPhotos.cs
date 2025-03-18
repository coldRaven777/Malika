namespace Malika.Infrastructure.Entities
{
    public class PersonPhotos
    {
        public int Id { get; set; }
        public Photo Photo { get; set; }
        public Person Person { get; set; }
    }
}