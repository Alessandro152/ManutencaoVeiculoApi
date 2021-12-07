using ManutencaoVeiculoApi.Domain.Entities;
using System.Collections.Generic;

namespace ManutencaoVeiculoApi.Domain.Commands
{
    public class ClienteManutencaoInsertCommand : Command
    {
        public ClienteManutencaoInsertCommand(string nome, string endereco, string email, string telefone, IList<VeiculoModel> veiculos)
        {
            Nome = nome;
            Endereco = endereco;
            EMail = email;
            Telefone = telefone;
            Veiculo = veiculos;
        }

        public string Nome { get; }

        public string Endereco { get; }

        public string EMail { get; }

        public string Telefone { get; }

        public IList<VeiculoModel> Veiculo { get; }
    }
}
