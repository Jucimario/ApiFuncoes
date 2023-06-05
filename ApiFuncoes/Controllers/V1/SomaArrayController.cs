using ApiFuncoes.Services.V1.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiFuncoes.Controllers.V1;

[Route("api/v1/[controller]")]
[ApiController]
public class SomaArrayController : ControllerBase
{
    private readonly ISomaArrayService _somaArrayService;

    public SomaArrayController(ISomaArrayService somaArrayService)
    {
        _somaArrayService = somaArrayService ??
                throw new ArgumentNullException(nameof(somaArrayService));
    }

    [HttpPost()]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status411LengthRequired)]
    public ActionResult GetSomaArray([FromBody] long[] numeros)
    {
        try
        {            
            return Ok(_somaArrayService.SomaArray(numeros));
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status411LengthRequired,
                                    ex.Message);
        }
    }
}
