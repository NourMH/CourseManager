namespace Interview.CourseManager.efCoreCode.efCoreClasses
{
    public class CourseReservation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        //TODO: fill your model here 
    }
}
