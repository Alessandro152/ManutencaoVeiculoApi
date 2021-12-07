using ManutencaoVeiculoApi.Domain.Commands;
using System.Threading.Tasks;

namespace ManutencaoVeiculoApi.Domain.Interface
{
    public interface IBusHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task<TResult> SendCommand<TResult, TCommand>(TCommand command) where TCommand : Command;
    }
}
