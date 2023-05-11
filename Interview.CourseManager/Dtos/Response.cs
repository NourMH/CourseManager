namespace Interview.CourseManager.Dtos
{
    public class Response <T> where T : class
    {
        public bool status { get; set; }
        public T Data { get; set; }
        public string Massage { get; set; }
    }
}
