using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MundialClubes.Entidades.EF;
using MundialClubes.Logica;
using MundialClubes.Web.Models.Dtos;

namespace MundialClubes.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ArbitroController : ControllerBase
{
    private readonly IArbitroLogica _arbitroLogica;
    private readonly IMapper _mapper;

    public ArbitroController(IArbitroLogica arbitroLogica, IMapper mapper)
    {
        _arbitroLogica = arbitroLogica;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult ObtenerArbitros()
    {
        return _arbitroLogica.ObtenerTodosLosArbitros() is { Count: > 0 } arbitros
            ? Ok(arbitros)
            : NotFound("No se encontraron árbitros.");
    }

    [HttpPost]
    public IActionResult CrearArbitro([FromBody] Arbitro arbitro)
    {

        if (arbitro != null)
        {
            _arbitroLogica.AgregarArbitro(arbitro);
            return CreatedAtAction(nameof(ObtenerArbitroPorId), new { id = arbitro.IdArbitro }, arbitro);
        }

        return BadRequest();

    }

    [HttpGet("{id}")]
    public ActionResult<Arbitro> ObtenerArbitroPorId(int id)
    {
        var arbitro = _arbitroLogica.ObtenerArbitroPorId(id);
        if (arbitro == null)
        {
            return NotFound();
        }
        var arbitroDto = _mapper.Map<ArbitroDto>(arbitro);
        return Ok(arbitroDto);
    }
}
