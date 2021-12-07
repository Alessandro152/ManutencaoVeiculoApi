using ManutencaoVeiculoApi.Application.Interface;
using ManutencaoVeiculoApi.Application.Interface.Cliente;
using ManutencaoVeiculoApi.Domain.Commands;
using ManutencaoVeiculoApi.Domain.Entities;
using ManutencaoVeiculoApi.Domain.Interface;
using System.Threading.Tasks;

namespace ManutencaoVeiculoApi.Application.AppServices.Cliente
{
    public class ClienteService : IClienteService
    {
        private readonly IBusHandler _bus;
        private readonly IUnitOfWork _uow;

        public ClienteService(IBusHandler bus, IUnitOfWork uow)
        {
            _bus = bus;
            _uow = uow;
        }

        public Task SalvarCliente(ClienteModel cliente)
        {
            var command = new ClienteManutencaoInsertCommand(cliente.Nome, cliente.Endereco, cliente.EMail, cliente.Telefone, cliente.Veiculo);

            var result = _bus.SendCommand<bool, ClienteManutencaoInsertCommand>(command).Result;

            if (result)
            {
                _uow.Commit();
            }
            else
            {
                _uow.RollBack();
            }

            return Task.FromResult(result);
        }
    }
}
