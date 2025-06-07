using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MundialClubes.Entidades.EF;
using MundialClubes.Logica;
using MundialClubes.Web.Models.Dtos;

namespace MundialClubes.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TorneoController : ControllerBase
{
    private readonly ITorneoLogica _torneoLogica;
    private readonly IMapper _mapper;


    public TorneoController(ITorneoLogica torneoLogica, IMapper mapper)
    {
        _torneoLogica = torneoLogica;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult ObtenerTodosLosTorneos()
    {
        var torneos = _torneoLogica.ObtenerTodosLosTorneos();
        var torneosDto = _mapper.Map<List<TorneoDto>>(torneos);
        return Ok(torneosDto);
    }

    [HttpPost]
    public IActionResult CrearTorneo([FromBody] TorneoDto torneoDto)
    {
        if (torneoDto == null)
        {
            return BadRequest("El torneo no puede ser nulo.");
        }

        var torneoEntidad = _mapper.Map<Torneo>(torneoDto);
        _torneoLogica.CrearTorneo(torneoEntidad);

        // Asumiendo que CrearTorneo setea IdTorneo en la entidad:
        var torneoDtoResultado = _mapper.Map<TorneoDto>(torneoEntidad);

        return CreatedAtAction(nameof(ObtenerTorneoPorId), new { id = torneoDtoResultado.IdTorneo }, torneoDtoResultado);
    }


    //Agregar club a torneo
    [HttpPost("{idTorneo}/club/{idClub}")]
    public IActionResult AgregarClubATorneo(int idTorneo, int idClub)
    {
        _torneoLogica.AgregarClubATorneo(idTorneo, idClub);
        return NoContent();
    }

    //Obtener torneo por id
    [HttpGet("{id}")]
    public IActionResult ObtenerTorneoPorId(int id)
    {
        var torneo = _torneoLogica.ObtenerTorneoPorId(id);
        if (torneo == null)
        {
            return NotFound();
        }
        var torneoDto = _mapper.Map<TorneoDto>(torneo);
        return Ok(torneoDto);
    }


    //Eliminar torneo
    [HttpDelete("{idTorneo}")]
    public IActionResult EliminarTorneo(int idTorneo)
    {
        _torneoLogica.EliminarTorneo(idTorneo);
        return NoContent();
    }

    //Eliminar club de torneo
    [HttpDelete("{idTorneo}/club/{idClub}")]
    public IActionResult EliminarClubDeTorneo(int idTorneo, int idClub)
    {
        _torneoLogica.EliminarClubDeTorneo(idTorneo, idClub);
        return NoContent();
    }
}
