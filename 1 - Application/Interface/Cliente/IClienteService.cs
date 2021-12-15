namespace ManutencaoVeiculoApi.Application.Interface.Cliente
{
    using ManutencaoVeiculoApi.Domain.Entities;
    using System.Threading.Tasks;

    public interface IClienteService
    {
        Task SalvarCliente(ClienteModel cliente);
    }
}
