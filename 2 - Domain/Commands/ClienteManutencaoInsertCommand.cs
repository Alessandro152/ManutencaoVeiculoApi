namespace ManutencaoVeiculoApi.Domain.Commands
{
    public class ClienteManutencaoInsertCommand : Command
    {
        public ClienteManutencaoInsertCommand(string nome, string endereco, string email, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            EMail = email;
            Telefone = telefone;
        }

        public string Nome { get; }

        public string Endereco { get; }

        public string EMail { get; }

        public string Telefone { get; }
    }
}
