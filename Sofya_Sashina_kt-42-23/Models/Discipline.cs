
namespace Sofya_Sashina_kt_42_23.Models
{
    public class Discipline
    {
        public int DisciplineId { get; set; }

        public string Name { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public List<Grade> Grades { get; set; } = new();
    }
}