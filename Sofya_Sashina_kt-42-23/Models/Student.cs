
namespace Sofya_Sashina_kt_42_23.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int GroupId { get; set; }

        public bool IsDeleted { get; set; }

        public Group Group { get; set; } = null!;

        public List<Grade> Grades { get; set; } = new();
    }
}