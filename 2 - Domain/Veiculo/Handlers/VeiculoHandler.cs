namespace ManutencaoVeiculoApi.Domain.Handlers.Veiculo
{
    using ManutencaoVeiculoApi.Domain.Interface.Repositories;
    using ManutencaoVeiculoApi.Domain.Commands.Veiculo;
    using ManutencaoVeiculoApi.Domain.Interface;
    using System;
    using System.Threading.Tasks;
    using ManutencaoVeiculoApi.Domain.Validations.Veiculo;
    using ManutencaoVeiculoApi.Domain.Notifications;

    public class VeiculoHandler : IHandler<VeiculoCommand>
    {
        private readonly IVeiculoRepository _veiculoRepository;
        private readonly VeiculoValidation _validator;
        private readonly NotificationContext _notification;

        public VeiculoHandler(IVeiculoRepository veiculoRepository, NotificationContext notification)
        {
            _veiculoRepository = veiculoRepository;
            _validator = new VeiculoValidation();
            _notification = notification;
        }

        public Task<bool> Handle(VeiculoCommand message)
        {
            if (message == null)
            {
                return Task.FromResult(false);
            }

            if (!_validator.Validate(message).IsValid)
            {
                return Task.FromResult(false);
            }

            try
            {
                var result = _veiculoRepository.Add(message.VeiculoId, message.ClienteId, message.Marca, message.Modelo, message.Ano, message.Cor, message.Placa);

                if (!result)
                {
                    _notification.AddNotification("Erro", $"Falha imprevista ao persistir o(s) veículo(s). Cliente = {message.ClienteId}.");
                    return Task.FromResult(false);
                }

                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
