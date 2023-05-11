namespace Interview.CourseManager.efCoreCode.efCoreClasses
{
    public class ClubBranch
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public ICollection<CourseBranch> CourseBranches { get; set; } = new HashSet<CourseBranch>();


        public ClubBranch()
        {

        }
        ClubBranch(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("Name can not be empty");
            BranchName = name;
        }
    }
}
