using ManutencaoVeiculoApi.Application.Interface;
using ManutencaoVeiculoApi.Domain.Commands.Veiculo;
using ManutencaoVeiculoApi.Domain.Interface;
using System.Threading.Tasks;

namespace ManutencaoVeiculoApi.Domain.Handlers.Veiculo
{
    public class VeiculoHandler : IHandler<VeiculoCommand>
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoHandler(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public async Task<bool> Handle(VeiculoCommand message)
        {
            return await _veiculoRepository.Add(message).ConfigureAwait(false);
        }
    }
}
