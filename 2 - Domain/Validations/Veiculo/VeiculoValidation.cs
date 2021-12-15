namespace ManutencaoVeiculoApi.Domain.Validations.Veiculo
{
    using ManutencaoVeiculoApi.Domain.Commands.Veiculo;
    using ManutencaoVeiculoApi.Domain.Interface;
    using System;

    public class VeiculoValidation : IValidator<VeiculoCommand>
    {
        public bool Validate(VeiculoCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
