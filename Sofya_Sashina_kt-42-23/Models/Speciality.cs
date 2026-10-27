
namespace Sofya_Sashina_kt_42_23.Models
{
    public class Speciality
    {
        public int SpecialityId { get; set; }

        public string Title { get; set; } = null!;//название

        public string Code { get; set; } = null!;//код специальности

        public List<Group> Groups { get; set; } = new();//у одной специальности много групп
    }
}