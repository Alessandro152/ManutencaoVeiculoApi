using ManutencaoVeiculoApi.Domain.Commands;
using ManutencaoVeiculoApi.Domain.Interface;

namespace ManutencaoVeiculoApi.Infra.Repositories.PersistRepository
{
    public class ClienteRepository : IClienteRepository
    {
        public ClienteRepository()
        {
            
        }

        public bool GravarCliente(ClienteManutencaoInsertCommand message)
        {
            throw new System.NotImplementedException();
        }
    }
}
