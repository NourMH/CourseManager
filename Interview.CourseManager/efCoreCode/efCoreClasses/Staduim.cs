namespace Interview.CourseManager.efCoreCode.efCoreClasses
{
    public class Staduim
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Staduim()
        {

        }
        public Staduim(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("Name can not be empty");
            Name = name;
        }
    }
}
