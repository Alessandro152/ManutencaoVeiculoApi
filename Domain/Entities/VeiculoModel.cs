using ManutencaoVeiculoApi.Domain.Entities.Common;
using ManutencaoVeiculoApi.Domain.Enum;

namespace ManutencaoVeiculoApi.Domain.Entities
{
    public class VeiculoModel : BaseModel
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Ano { get; set; }

        public VeiculoTipo Tipo { get; set; }

        public string Cor { get; set; }

        public string Placa { get; set; }
    }
}
