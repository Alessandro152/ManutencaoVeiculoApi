namespace ManutencaoVeiculoApi.Domain.Interface.Repositories
{
    using ManutencaoVeiculoApi.Domain.Commands;

    public interface IClienteRepository
    {
        bool Add(ClienteCommand message);
    }
}
