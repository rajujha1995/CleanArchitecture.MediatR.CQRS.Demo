namespace Dot7.Architecture.Application.StudentDetails.GetAllStudentDetails;

public class GetAllStudentDetailsMapper : Profile
{
    public GetAllStudentDetailsMapper()
    {
        CreateMap<Domain.Entities.StudentDetails, GetAllStudentDetailsResponse>();
    }
}
