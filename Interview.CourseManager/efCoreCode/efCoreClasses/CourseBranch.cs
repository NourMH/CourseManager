namespace Interview.CourseManager.efCoreCode.efCoreClasses
{
    public class CourseBranch
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int ClubBranchId { get; set; }
        public ClubBranch ClubBranch { get; set; }
    }
}
