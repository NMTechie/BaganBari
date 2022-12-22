namespace EdTech.Course.Domain.Entities
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<Chapter> Chapters { get; set; }
    }
}