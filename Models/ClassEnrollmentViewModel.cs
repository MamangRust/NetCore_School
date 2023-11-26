using schoolmanagement.Data;

namespace schoolmanagement.Models;

public class ClassEnrollmentViewModel
{
    public ClassViewModel? Class { get; set; }
    public List<StudentEnrollmentViewModel> Students { get; set; } = new List<StudentEnrollmentViewModel>();
}