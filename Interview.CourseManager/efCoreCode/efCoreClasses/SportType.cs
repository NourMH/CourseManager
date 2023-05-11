namespace Interview.CourseManager.efCoreCode.efCoreClasses
{
    public class SportType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SportType()
        {

        }
        SportType(string name) {

            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("Name can not be empty");
            Name = name.Trim();
        } 

    }
}
