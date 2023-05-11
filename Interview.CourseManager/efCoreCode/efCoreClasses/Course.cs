namespace Interview.CourseManager.efCoreCode.efCoreClasses
{
    public class Course
    {
        //TODO: fill your model here 
        #region property
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public int Gender { get; set; }
        public double Cost { get; set; }
        public double Capacity { get; set; }
        public int Status { get; set; }

        #endregion
        #region  Foreign Keys 
        public int? AcademyId { get; set; }
        public Academy Academy { get; set; }
        public int StaduimId { get; set; }
        public Staduim Staduim { get; set; }
        #endregion
        #region Navigation property
        public ICollection<CourseBranch> CourseBranches { get; set; } = new HashSet<CourseBranch>();
        public ICollection<CourseReservation> CourseReservations { get; set; } = new HashSet<CourseReservation>();
         
        #endregion


    }
}
