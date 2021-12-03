using ManutencaoVeiculoApi.Domain.Commands;
using ManutencaoVeiculoApi.Domain.Interface;
using System.Threading.Tasks;

namespace ManutencaoVeiculoApi.Domain.Handlers
{
    public class ClienteManutencaoInserthandler : IHandler<ClienteManutencaoInsertCommand>
    {
        public ClienteManutencaoInserthandler()
        {

        }

        public Task Handle(ClienteManutencaoInsertCommand message)
        {
            throw new System.NotImplementedException();
        }
    }
}
