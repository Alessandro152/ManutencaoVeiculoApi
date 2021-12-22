namespace ManutencaoVeiculoApi.Domain.Commands
{
    using ManutencaoVeiculoApi.Domain.Entities;
    using System;
    using System.Collections.Generic;

    public class ClienteCommand : Command
    {
        public ClienteCommand(string nome, string endereco, string email, string telefone, IEnumerable<VeiculoModel> veiculo)
        {
            Nome = nome;
            Endereco = endereco;
            EMail = email;
            Telefone = telefone;
            ClienteId = Guid.NewGuid();
            Veiculo = veiculo;
        }

        public Guid ClienteId { get; }

        public string Nome { get; }

        public string Endereco { get; }

        public string EMail { get; }

        public string Telefone { get; }

        public IEnumerable<VeiculoModel> Veiculo { get; }
    }
}
