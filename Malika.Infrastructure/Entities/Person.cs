namespace Malika.Infrastructure.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio {  get; set; }
        public Gender Gender {  get; set; }
        public DateTime DOB { get; set; }
        public string Location { get; set; }
        public string Birthplace { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}