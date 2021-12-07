using ManutencaoVeiculoApi.Domain.Entities;
using System.Threading.Tasks;

namespace ManutencaoVeiculoApi.Application.Interface.Cliente
{
    public interface IClienteService
    {
        Task SalvarCliente(ClienteModel cliente);
    }
}
