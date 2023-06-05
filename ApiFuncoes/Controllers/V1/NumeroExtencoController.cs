using ApiFuncoes.Services.V1.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiFuncoes.Controllers.V1;

[Route("api/v1/[controller]")]
[ApiController]
public class NumeroExtencoController : ControllerBase
{
    private readonly INumeroExtencoService _numeroExtencoService;

    public NumeroExtencoController(INumeroExtencoService numeroExtencoService)
    {
        _numeroExtencoService = numeroExtencoService ??
                throw new ArgumentNullException(nameof(numeroExtencoService));
    }

    [HttpGet("{numero:long}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status501NotImplemented)]
    public ActionResult GetNumeroExtenso([FromRoute] long numero)
    {
        try
        {            
            return Ok(_numeroExtencoService.NumeroExtenso(numero));
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status501NotImplemented,
                     ex.Message);            
        }
      
    }
}
