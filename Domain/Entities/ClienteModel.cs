namespace ManutencaoVeiculoApi.Domain.Entities
{
    public class ClienteModel
    {
        public string Nome { get; set; }

        public string EMail { get; set; }

        public string Telefone { get; set; }

        public IList<VeiculoModel> Veiculo { get; set; }
    }
}
