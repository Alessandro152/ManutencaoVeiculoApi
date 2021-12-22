namespace ManutencaoVeiculoApi.Application.AppServices.Cliente
{
    using ManutencaoVeiculoApi.Application.Interface;
    using ManutencaoVeiculoApi.Application.Interface.Cliente;
    using ManutencaoVeiculoApi.Domain.Commands;
    using ManutencaoVeiculoApi.Domain.Entities;
    using ManutencaoVeiculoApi.Domain.Interface;
    using System.Threading.Tasks;

    public class ClienteService : IClienteService
    {
        private readonly IBusHandler _bus;
        private readonly IUnitOfWork _uow;

        public ClienteService(IBusHandler bus, IUnitOfWork uow)
        {
            _bus = bus;
            _uow = uow;
        }

        public async Task SalvarCliente(ClienteModel cliente)
        {
            var clienteCommand = new ClienteCommand(cliente.Nome, cliente.Endereco, cliente.EMail, cliente.Telefone, cliente.Veiculo);
            var result = await _bus.SendCommand<bool, ClienteCommand>(clienteCommand).ConfigureAwait(false);

            if (!result)
            {
                _uow.RollBack();
                return;
            }

            _uow.Commit();
        }
    }
}
