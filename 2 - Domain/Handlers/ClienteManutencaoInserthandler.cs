using ManutencaoVeiculoApi.Domain.Commands;
using ManutencaoVeiculoApi.Domain.Interface;
using System.Threading.Tasks;

namespace ManutencaoVeiculoApi.Domain.Handlers
{
    public class ClienteManutencaoInserthandler : IHandler<ClienteManutencaoInsertCommand>
    {
        private IClienteRepository _clienteRepository;

        public ClienteManutencaoInserthandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Task<bool> Handle(ClienteManutencaoInsertCommand message)
        {
            if (message == null)
            {
                return Task.FromResult(false);
            }

            var result = _clienteRepository.GravarCliente(message);

            return Task.FromResult(result);
        }
    }
}
