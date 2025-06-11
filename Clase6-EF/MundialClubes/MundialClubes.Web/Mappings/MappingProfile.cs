using AutoMapper;
using MundialClubes.Entidades.EF;
using MundialClubes.Web.Models.Dtos;

namespace MundialClubes.Web.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Torneo, TorneoDto>().ReverseMap();
        CreateMap<Club, ClubDto>().ReverseMap();
        CreateMap<Arbitro, ArbitroDto>().ReverseMap();
    }
}