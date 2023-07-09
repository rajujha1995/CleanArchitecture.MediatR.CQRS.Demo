namespace Dot7.Architecture.Application.StudentDetails.CreateStudentDetails;

public class CreateStudentDetailsCommandHandler : IRequestHandler<CreateStudentDetailsRequest, int>
{
    private readonly ICQRSDbContext _dbContext;
    private readonly IMapper _mapper;

    public CreateStudentDetailsCommandHandler(ICQRSDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateStudentDetailsRequest request, CancellationToken cancellationToken)
    {
        var newStudentDetails = _mapper.Map<Domain.Entities.StudentDetails>(request);
        _dbContext.StudentDetails.Add(newStudentDetails);
        await _dbContext.SaveToDbAsync();
        return newStudentDetails.Id;
    }
}
