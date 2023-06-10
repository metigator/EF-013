namespace EF013.TPH.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public decimal Price { get; set; }

        public ICollection<Section> Sections { get; set; } = new List<Section>();

    }
}
