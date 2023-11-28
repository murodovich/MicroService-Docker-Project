namespace School_Domain.Entities.Models;
public class Grade
{
    public int GradeId { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public DateTime GradeDate { get; set; }
    public float Score { get; set; }
}
