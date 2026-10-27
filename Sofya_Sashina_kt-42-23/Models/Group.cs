namespace Sofya_Sashina_kt_42_23.Models
{
    public class Group
    {
        public int GroupId { get; set; }

        public string Name { get; set; } = null!;

        public int Course { get; set; }

        public int SpecialityId { get; set; }

        public bool IsDeleted { get; set; }

        public Speciality Speciality { get; set; } = null!;

        public List<Student> Students { get; set; } = new();
    }
}