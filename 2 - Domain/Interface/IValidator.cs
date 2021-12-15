namespace ManutencaoVeiculoApi.Domain.Interface
{
    using ManutencaoVeiculoApi.Domain.Commands;

    public interface IValidator<T> where T : Command
    {
        bool Validate(T message);
    }
}
