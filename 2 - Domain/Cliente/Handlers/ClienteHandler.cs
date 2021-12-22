namespace ManutencaoVeiculoApi.Domain.Handlers
{
    using ManutencaoVeiculoApi.Domain.Commands;
    using ManutencaoVeiculoApi.Domain.Commands.Veiculo;
    using ManutencaoVeiculoApi.Domain.Enum;
    using ManutencaoVeiculoApi.Domain.Interface;
    using ManutencaoVeiculoApi.Domain.Interface.Repositories;
    using ManutencaoVeiculoApi.Domain.Notifications;
    using System.Threading.Tasks;

    public class ClienteHandler : IHandler<ClienteCommand>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IBusHandler _bus;
        private readonly NotificationContext _notification;

        public ClienteHandler(IClienteRepository clienteRepository, IBusHandler bus, NotificationContext notification)
        {
            _clienteRepository = clienteRepository;
            _bus = bus;
            _notification = notification;
        }

        public Task<bool> Handle(ClienteCommand message)
        {
            if (message == null)
            {
                return Task.FromResult(false);
            }

            var result = _clienteRepository.Add(message);

            if (!result)
            {
                //TODO - Criar domain notification
                return Task.FromResult(false);
            }

            foreach (var item in message.Veiculo)
            {
                var veiculoCommand = new VeiculoCommand(message.ClienteId, item.Marca, item.Modelo, item.Ano, VeiculoTipo.Carro, item.Cor, item.Placa);
                _bus.SendCommand(veiculoCommand);

                if (_notification.HasNotifications)
                {
                    break;
                }
            }

            return Task.FromResult(true);
        }
    }
}
