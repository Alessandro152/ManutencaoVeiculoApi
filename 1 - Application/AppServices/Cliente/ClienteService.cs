namespace ManutencaoVeiculoApi.Application.AppServices.Cliente
{
    using ManutencaoVeiculoApi.Application.Interface;
    using ManutencaoVeiculoApi.Application.Interface.Cliente;
    using ManutencaoVeiculoApi.Application.ViewModel;
    using ManutencaoVeiculoApi.Domain.Commands;
    using ManutencaoVeiculoApi.Domain.Commands.Veiculo;
    using ManutencaoVeiculoApi.Domain.Entities;
    using ManutencaoVeiculoApi.Domain.Enum;
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
            var clienteCommand = new ClienteCommand(cliente.Nome, cliente.Endereco, cliente.EMail, cliente.Telefone);
            var result = await _bus.SendCommand<bool, ClienteCommand>(clienteCommand).ConfigureAwait(false);

            foreach (var item in cliente.Veiculo)
            {
                var veiculoCommand = new VeiculoCommand(cliente.Id, item.Marca, item.Modelo, item.Ano, VeiculoTipo.Carro, item.Cor, item.Placa);
                await _bus.SendCommand(veiculoCommand).ConfigureAwait(false);
            }

            if (result) { _uow.Commit(); } else { _uow.RollBack(); }
        }
    }
}
