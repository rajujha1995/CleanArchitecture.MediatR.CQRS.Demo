using Dot7.Architecture.Application.StudentDetails.CreateStudentDetails;

namespace Dot7.Architecture.Api.Controllers;

[Route("[controller]")]
[ApiController]
public class StudentDetailsController : ControllerBase
{
    private readonly IMediator _mediator;

    public StudentDetailsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        var response = await _mediator.Send(new GetAllStudentDetailsRequest());
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(CreateStudentDetailsRequest request)
    {
        var newlyCreateStudentId = await _mediator.Send(request);
        return Ok(newlyCreateStudentId);
    }
}
