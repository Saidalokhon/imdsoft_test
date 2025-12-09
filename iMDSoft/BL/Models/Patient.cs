namespace BL.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public DateTime DateOfBirth { get; set; } = new DateTime(1900, 1, 1);
        public string Gender { get; set; } = String.Empty;
        public ICollection<Test> Tests { get; set; } = new List<Test>();
    }
}
