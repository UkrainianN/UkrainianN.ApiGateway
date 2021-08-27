using Microsoft.AspNetCore.Mvc;
namespace UkrainianN.ApiGateway.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ApiBaseController : ControllerBase
    {

    }
}