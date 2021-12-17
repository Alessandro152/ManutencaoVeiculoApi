namespace ManutencaoVeiculoApi.Domain.Validations.Veiculo
{
    using ManutencaoVeiculoApi.Domain.Commands.Veiculo;
    using ManutencaoVeiculoApi.Domain.Interface;

    public class VeiculoValidation : IValidatorHandler<VeiculoCommand>
    {
        public VeiculoValidation()
        {
        }

        public bool Validate(VeiculoCommand message)
        {
            return true;
        }
    }
}
