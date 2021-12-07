using ManutencaoVeiculoApi.Domain.Commands;

namespace ManutencaoVeiculoApi.Domain.Interface
{
    public interface IClienteRepository
    {
        bool GravarCliente(ClienteManutencaoInsertCommand message);
    }
}
