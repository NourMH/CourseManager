using Interview.CourseManager.Dtos;
using Interview.CourseManager.efCoreCode;
using Interview.CourseManager.efCoreCode.efCoreClasses;
using Interview.CourseManager.Services.Interfaces;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Interview.CourseManager.Services.Implementations
{
    public class CourseBrancheService : ICourseBrancheService
    {
        //TODO fill your service Implementation Here...
        ApplicationDbContext db;
        public CourseBrancheService(ApplicationDbContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public List<BaseDto> GetCourseBranches()
        {
            return db.CourseBranchs.Select(n => new BaseDto
            {
                Id = n.Id,
                Name = n.ClubBranch.BranchName
            }).ToList();

        }





    }
}
