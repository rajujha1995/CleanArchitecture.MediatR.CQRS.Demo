namespace Dot7.Architecture.Application.StudentDetails.CreateStudentDetails;

public class CreateStudentDetailsRequest:IRequest<int>
{
    public string? StudentName { get; set; }
    public string? StudentEmail { get; set; }
    public string? StudentAddress { get; set; }
    public int StudentAge { get; set; }
}
