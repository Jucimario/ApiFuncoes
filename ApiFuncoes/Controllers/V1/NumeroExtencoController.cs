using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFuncoes.Controllers.V1;

[Route("api/v1/[controller]")]
[ApiController]
public class NumeroExtencoController : ControllerBase
{

    [HttpGet("NumeroExtenso/{numero:int}")]
    public ActionResult<string> NumeroExtenso(int numero)
    {
        return NoContent();
    }
}
