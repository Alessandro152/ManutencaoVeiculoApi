using ManutencaoVeiculoApi.Application.Interface;
using ManutencaoVeiculoApi.Domain.Commands.Veiculo;
using ManutencaoVeiculoApi.Domain.Entities;
using System.Threading.Tasks;

namespace ManutencaoVeiculoApi.Infra.Repositories.PersistRepository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        public VeiculoRepository()
        {

        }

        public Task<bool> Add(VeiculoCommand command)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(VeiculoModel veiculo)
        {
            throw new System.NotImplementedException();
        }
    }
}
