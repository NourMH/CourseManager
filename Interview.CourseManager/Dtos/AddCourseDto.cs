using Interview.CourseManager.efCoreCode.efCoreClasses;
using System.ComponentModel.DataAnnotations;

namespace Interview.CourseManager.Dtos
{
    public class AddCourseDto
    {
        [Required(ErrorMessage ="course name is required")]
        public string Name { get; set; }

        public DateTime CreationDate { get; set; }
        [Required(ErrorMessage = "you have to enter count of reservation")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid Count reservation ")]

        public string CountOfReservation { get; set; }
        public string StartDate { get; set; }
        public int Duration { get; set; }
        public int? AcademyId { get; set; }
        public int StaduimId { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public int Gender { get; set; }
        public double Cost { get; set; }
        public double Capacity { get; set; }
        public int Status { get; set; }
        public List<int> CourseBranches { get; set; }
        public List<AddCourseReservationDto> CourseReservations { get; set; } = new List<AddCourseReservationDto>();

    }
}
