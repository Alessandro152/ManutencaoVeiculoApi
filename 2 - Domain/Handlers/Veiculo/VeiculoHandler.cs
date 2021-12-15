namespace ManutencaoVeiculoApi.Domain.Handlers.Veiculo
{
    using ManutencaoVeiculoApi.Application.Interface;
    using ManutencaoVeiculoApi.Domain.Commands.Veiculo;
    using ManutencaoVeiculoApi.Domain.Interface;
    using System;
    using System.Threading.Tasks;

    public class VeiculoHandler : IHandler<VeiculoCommand>
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoHandler(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public Task<bool> Handle(VeiculoCommand message)
        {
            if (message == null)
            {
                return Task.FromResult(false);
            }

            try
            {
                return Task.FromResult(_veiculoRepository.Add(message.ClienteId, message.Marca, message.Modelo, message.Ano, message.Cor, message.Placa));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
