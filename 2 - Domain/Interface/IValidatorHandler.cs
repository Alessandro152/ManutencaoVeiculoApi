namespace ManutencaoVeiculoApi.Domain.Interface
{
    using ManutencaoVeiculoApi.Domain.Commands;

    public interface IValidatorHandler<T> where T : Command
    {
        bool Validate(T message);
    }
}
