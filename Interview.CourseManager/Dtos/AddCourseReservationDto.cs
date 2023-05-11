using System.ComponentModel.DataAnnotations;

namespace Interview.CourseManager.Dtos
{
    public class AddCourseReservationDto
    {
        [Range(minimum:0,maximum:6, ErrorMessage ="Invalid Day")]
        public int Day { get; set; }
    //    public DateTime Time { get; set; }
    }
}
