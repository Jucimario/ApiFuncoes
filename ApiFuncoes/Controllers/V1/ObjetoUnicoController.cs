using ApiFuncoes.Models;
using ApiFuncoes.Services.V1.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiFuncoes.Controllers.V1;

[Route("api/[controller]")]
[ApiController]
public class ObjetoUnicoController : ControllerBase
{
    private readonly IObjetoUnicoService<Produto> _objetoUnicoService;

    public ObjetoUnicoController(IObjetoUnicoService<Produto> objetoUnicoService)
    {
        _objetoUnicoService = objetoUnicoService ??
                throw new ArgumentNullException(nameof(objetoUnicoService));
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult ObjetoUnico([FromBody] List<Produto> produtos)
    {
        try
        { 
            return Ok(_objetoUnicoService.RemoverDuplicados(produtos));
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status400BadRequest,
                   ex.Message);
        }
    }
}
