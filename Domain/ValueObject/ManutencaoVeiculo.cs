using ManutencaoVeiculoApi.Domain.Entities;
using ManutencaoVeiculoApi.Domain.Enum;
using System;

namespace ManutencaoVeiculoApi.Domain.ValueObject
{
    public class ManutencaoVeiculo
    {
        public ClienteModel Cliente { get; set; }

        public VeiculoModel Veiculo { get; set; }

        public DateTime ManutencaoData { get; set; }

        public ManutencaoTipo TipoManutencao { get; set; }
    }
}
