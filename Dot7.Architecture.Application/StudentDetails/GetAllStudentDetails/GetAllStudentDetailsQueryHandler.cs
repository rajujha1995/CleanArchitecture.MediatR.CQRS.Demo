namespace Dot7.Architecture.Application.StudentDetails.GetAllStudentDetails;

public class GetAllStudentDetailsQueryHandler : IRequestHandler<GetAllStudentDetailsRequest, List<GetAllStudentDetailsResponse>>
{
    private readonly ICQRSDbContext _dbContext;
    private readonly IMapper _mapper;
    public GetAllStudentDetailsQueryHandler(ICQRSDbContext dbContext,
    IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }
    public Task<List<GetAllStudentDetailsResponse>> Handle(GetAllStudentDetailsRequest request, CancellationToken cancellationToken)
    {
        return _dbContext.StudentDetails.ProjectTo<GetAllStudentDetailsResponse>(_mapper.ConfigurationProvider)
        .ToListAsync();
    }
}
