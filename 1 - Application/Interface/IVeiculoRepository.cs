using ManutencaoVeiculoApi.Domain.Commands.Veiculo;
using ManutencaoVeiculoApi.Domain.Entities;
using System.Threading.Tasks;

namespace ManutencaoVeiculoApi.Application.Interface
{
    public interface IVeiculoRepository
    {
        Task<bool> Add(VeiculoCommand command);

        Task<bool> Update(VeiculoModel veiculo);

        Task<bool> Remove(int id);
    }
}
