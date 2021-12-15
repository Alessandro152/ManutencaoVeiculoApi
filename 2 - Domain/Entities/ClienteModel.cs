using ManutencaoVeiculoApi.Domain.Entities.Common;
using System.Collections.Generic;

namespace ManutencaoVeiculoApi.Domain.Entities
{
    public class ClienteModel : BaseModel
    {
        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string EMail { get; set; }

        public string Telefone { get; set; }

        public string Cpf { get; set; }

        public IEnumerable<VeiculoModel> Veiculo { get; set; }
    }
}
