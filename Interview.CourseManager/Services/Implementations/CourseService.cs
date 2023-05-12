using Interview.CourseManager.Dtos;
using Interview.CourseManager.efCoreCode;
using Interview.CourseManager.efCoreCode.efCoreClasses;
using Interview.CourseManager.Services.Interfaces;
using Microsoft.AspNetCore.DataProtection.Repositories;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Interview.CourseManager.Services.Implementations
{
    public class CourseService : ICourseService
    {
        //TODO fill your service Implementation Here...
        ApplicationDbContext db;
        public CourseService(ApplicationDbContext _db)
        {
            db = _db;
        }
        public Response<List<CourseReservationDto>> CreateCourse(AddCourseDto model)
        {
            Response<List<CourseReservationDto>> response = new ();

            try
            {
                //if (!db.Academys.Any(f => f.Id == model.AcademyId))
                //{
                //    response.status = false;
                //    response.Massage = $"No Academy with this Id{model.AcademyId}";
                //    return response;
                //}
                if (!db.Staduims.Any(f => f.Id == model.StaduimId))
                {
                    response.status = false;
                    response.Massage = $"No Academy with this Id{model.StaduimId}";
                    return response;
                }
                List<CourseReservationDto> reservations;
                if (DateTime.TryParse(model.StartDate, out DateTime sDate))
                {
                    reservations = SetCouseReservation(int.Parse(model.CountOfReservation), model.Duration, model.CourseReservations, sDate);
                }
                else
                {
                    reservations = SetCouseReservation(int.Parse(model.CountOfReservation), model.Duration, model.CourseReservations, DateTime.Now);
                }
                if (reservations.Any(n => n.Reservied == true))
                {
                    response.status = false;
                    response.Massage = $"there is days aleady reseved befour ";
                    response.Data = reservations;
                    return response;
                }
                var course = new Course()
                {
                    Name = model.Name,
                    StaduimId = model.StaduimId,
                    CreationDate = DateTime.Now,
                    AcademyId = model.AcademyId,
                    AgeFrom = model.AgeFrom,
                    AgeTo = model.AgeTo,
                    Capacity = model.Capacity,
                    Cost = model.Cost,
                    Gender = model.Gender,

                    CourseBranches = model.CourseBranches.Select(n => new CourseBranch
                    {
                        ClubBranchId = n
                    }).ToList(),
                    CourseReservations = reservations.Select(n => new CourseReservation
                    {
                        Date = n.Date,
                        
                    }).ToList()
                };
                db.Courses.Add(course);
                db.SaveChanges();
                response.status = true;
                response.Data = reservations;
                response.Massage = "Sucssed saving ";
                return response;
            }
            catch (Exception e)
            {
                response.status = false;
                response.Massage = e.Message;
                return response;
            }

           
        }
        public List<CourseReservationDto> SetCouseReservation(int count ,int duration, List<AddCourseReservationDto> model, DateTime startDate)
        {
            List<CourseReservationDto> reservations= new() ;
            for (int i = 0; i < count; i++)
            {
                CourseReservationDto reservation = new();
                DateTime nextDayOfWeek = new();
                int hours = 0;
                int minutes = 0;
                int day;
                if (model.Any(n => n.Day == (int)startDate.DayOfWeek) && i==0)
                {
                    day = model.Where(n => n.Day == (int)startDate.DayOfWeek).FirstOrDefault().Day;
                    nextDayOfWeek = startDate;
                     
                }
                else if(model.Any(n=>n.Day > (int)startDate.DayOfWeek))
                {
                    day = model.Where(n => n.Day > (int)startDate.DayOfWeek).Select(n=>n.Day).Min();
                    nextDayOfWeek = startDate.AddDays(day- (int)startDate.DayOfWeek) ;
                    startDate = nextDayOfWeek;
                }
                else if (model.Any(n => n.Day < (int)startDate.DayOfWeek))
                {

                    day = model.Where(n => n.Day < (int)startDate.DayOfWeek).Select(n => n.Day).Min();
                    nextDayOfWeek = startDate.AddDays( (int)startDate.DayOfWeek- day +1);
                    startDate= nextDayOfWeek;
                }
                else if (model.Any(n => n.Day == (int)startDate.DayOfWeek)&& model.Count()==1)
                {

                    //day = model.Where(n => n.Day < (int)startDate.DayOfWeek).Select(n => n.Day).Min();
                    nextDayOfWeek = startDate.AddDays(7);
                    startDate = nextDayOfWeek;
                }
                //  hours = model.Where(n => n.Day == day).First().Time.Hour;
                //   minutes = model.Where(n => n.Day == day).First().Time.Minute;
                reservation.Date =
                        new DateTime(nextDayOfWeek.Year,
                        nextDayOfWeek.Month,
                        nextDayOfWeek.Day,
                        hours, minutes, 0);

                if(db.CourseReservations.Any(n=> reservation.Date >= n.Date && reservation.Date<= n.Date.AddHours(duration)))
                {
                    reservation.Reservied = true;
                }
                reservations.Add(reservation);
            }
            return reservations;
        }





    }
}
