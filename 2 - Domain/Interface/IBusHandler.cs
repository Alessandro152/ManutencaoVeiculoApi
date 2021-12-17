namespace ManutencaoVeiculoApi.Domain.Interface
{
    using ManutencaoVeiculoApi.Domain.Commands;
    using System.Threading.Tasks;

    public interface IBusHandler
    {
        Task SendCommand<T>(T command) where T : Command;

        Task<TResult> SendCommand<TResult, TCommand>(TCommand command) where TCommand : Command;
    }
}
