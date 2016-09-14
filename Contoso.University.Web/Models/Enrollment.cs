namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; } //? indicates that the Grade is nullable, null means a grade is unknown not 0

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}