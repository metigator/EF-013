namespace EF013.TPC.Entities
{
    public class Enrollment
    {
        public int SectionId { get; set; }
        public int StudentId { get; set; }

        public Section Section { get; set; } = null!;
        public Participant Participant { get; set; } = null!;
    }
}
