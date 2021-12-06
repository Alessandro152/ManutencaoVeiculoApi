using ManutencaoVeiculoApi.Application.Interface;
using ManutencaoVeiculoApi.Domain.Commands.Veiculo;
using ManutencaoVeiculoApi.Domain.Entities;
using System.Threading.Tasks;

namespace ManutencaoVeiculoApi.Domain.Handlers.Veiculo
{
    public class VeiculoHandler
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoHandler(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public async Task<bool> Add(VeiculoModel veiculo)
        {
            var command = new VeiculoCommand(veiculo.Marca, veiculo.Modelo, veiculo.Ano, veiculo.Tipo, veiculo.Cor, veiculo.Placa);
            return await _veiculoRepository.Add(command).ConfigureAwait(false);
        }
    }
}
