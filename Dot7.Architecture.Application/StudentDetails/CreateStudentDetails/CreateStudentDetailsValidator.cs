namespace Dot7.Architecture.Application.StudentDetails.CreateStudentDetails;

public class CreateStudentDetailsValidator : AbstractValidator<CreateStudentDetailsRequest>
{
    public CreateStudentDetailsValidator()
    {
        RuleFor(x => x.StudentName).NotEmpty();
        RuleFor(x => x.StudentAddress).NotEmpty();
        RuleFor(x => x.StudentEmail).NotEmpty();
        RuleFor(x => x.StudentAge).NotEmpty();
    }
}
