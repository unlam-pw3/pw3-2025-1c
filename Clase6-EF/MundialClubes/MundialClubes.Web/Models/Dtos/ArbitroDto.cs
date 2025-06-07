using MundialClubes.Entidades.EF;

namespace MundialClubes.Web.Models.Dtos;

public class ArbitroDto
{
        public int IdArbitro { get; set; }

        public string Nombre { get; set; } = null!;

        public string Nacionalidad { get; set; } = null!;

}
