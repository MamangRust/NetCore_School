namespace schoolmanagement.Models;

public class StudentEnrollmentViewModel
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public bool IsEnrolled { get; set; }
}