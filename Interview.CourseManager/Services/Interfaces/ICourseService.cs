using Interview.CourseManager.Dtos;
using Interview.CourseManager.efCoreCode.efCoreClasses;

namespace Interview.CourseManager.Services.Interfaces
{
    public interface ICourseService
    {
        //TODO fill your service Here...
        Response<List<CourseReservationDto>> CreateCourse(AddCourseDto model);
        List<CourseReservationDto> SetCouseReservation(int count, int duration, List<AddCourseReservationDto> model, DateTime startDate);
    }
}
