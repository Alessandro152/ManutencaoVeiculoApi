namespace ManutencaoVeiculoApi.Domain.Handlers
{
    using ManutencaoVeiculoApi.Domain.Commands;
    using ManutencaoVeiculoApi.Domain.Interface;
    using ManutencaoVeiculoApi.Domain.Interface.Repositories;
    using System.Threading.Tasks;

    public class ClienteHandler : IHandler<ClienteCommand>
    {
        private IClienteRepository _clienteRepository;

        public ClienteHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Task<bool> Handle(ClienteCommand message)
        {
            if (message == null)
            {
                return Task.FromResult(false);
            }

            var result = _clienteRepository.Add(message);

            return Task.FromResult(result);
        }
    }
}
