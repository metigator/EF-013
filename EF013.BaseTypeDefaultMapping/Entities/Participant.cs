namespace EF013.BaseTypeDefaultMapping.Entities
{
    public class Participant
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public ICollection<Section> Sections { get; set; } = new List<Section>();
    }

    public class Individual : Participant
    {
        public string University { get; set; }
        public int YearOfGraduation { get; set; }
        public bool IsIntern { get; set; }
    }
    public class Coporate : Participant
    {
        public string Company { get; set; }
        public string JobTitle { get; set; }
    }

}
