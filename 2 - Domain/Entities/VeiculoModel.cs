namespace ManutencaoVeiculoApi.Domain.Entities
{
    using ManutencaoVeiculoApi.Domain.Entities.Common;
    using ManutencaoVeiculoApi.Domain.Enum;

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
