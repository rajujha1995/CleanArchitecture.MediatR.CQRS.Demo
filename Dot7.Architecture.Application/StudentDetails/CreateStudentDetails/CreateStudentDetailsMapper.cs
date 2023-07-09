namespace Dot7.Architecture.Application.StudentDetails.CreateStudentDetails;

public class CreateStudentDetailsMapper:Profile
{
    public CreateStudentDetailsMapper()
    {
        CreateMap<CreateStudentDetailsRequest, Domain.Entities.StudentDetails>();
    }
}
