using Interview.CourseManager.Dtos;
using Interview.CourseManager.efCoreCode;
using Interview.CourseManager.efCoreCode.efCoreClasses;
using Interview.CourseManager.Services.Interfaces;
using Microsoft.AspNetCore.DataProtection.Repositories;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Interview.CourseManager.Services.Implementations
{
    public class StuduimService : IStuduimService
    {
        //TODO fill your service Implementation Here...
        ApplicationDbContext db;
        public StuduimService(ApplicationDbContext _db)
        {
            db = _db;
        }
        

        public List<BaseDto> getStaduims()
        {
            return db.Staduims.Select(n => new BaseDto
            {
                Id = n.Id,
                Name = n.Name
            }).ToList();

        }





    }
}
