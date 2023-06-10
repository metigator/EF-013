namespace EF013.TPH.Entities
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

        public override string ToString()
        {
            return $"{Id}  | {LName}, {FName} | Graduted on ({YearOfGraduation}) From {University}" +
                $"({(IsIntern ? "Internship" : "")})";
        }
    }
    public class Coporate : Participant
    {
        public string Company { get; set; }
        public string JobTitle { get; set; }

        public override string ToString()
        {
            return $"{Id}  | {LName}, {FName} | ({JobTitle}) at {Company}";
        }
    }
}
