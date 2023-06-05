using ApiFuncoes.Services.V1.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiFuncoes.Controllers.V1;

[Route("api/v1/[controller]")]
[ApiController]
public class ExpressaoMatematicaController : ControllerBase
{

    private readonly IExpressaoMatematicaService _expressaoMatematicaService;

    public ExpressaoMatematicaController(IExpressaoMatematicaService expressaoMatematicaService)
    {
        _expressaoMatematicaService = expressaoMatematicaService ??
                throw new ArgumentNullException(nameof(expressaoMatematicaService));
    }

    
    [HttpGet()]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status415UnsupportedMediaType)]
    public ActionResult GetExpressaoMatematica([FromQuery] string expressao)
    {
        try
        {
            return Ok(_expressaoMatematicaService.ExpressaoMatematicaSimples(expressao));
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status415UnsupportedMediaType,
                                                       ex.Message);
        }
    }   

}
