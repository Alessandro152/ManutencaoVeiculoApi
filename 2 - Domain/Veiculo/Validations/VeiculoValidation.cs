namespace ManutencaoVeiculoApi.Domain.Validations.Veiculo
{
    using FluentValidation;
    using ManutencaoVeiculoApi.Domain.Commands.Veiculo;

    public class VeiculoValidation : AbstractValidator<VeiculoCommand>
    {
        public VeiculoValidation()
        {
            ValidarMarcaVeiculo();
        }

        private void ValidarMarcaVeiculo()
        {
            RuleFor(p => p.Marca)
                .NotEmpty()
                    .WithMessage("A marca do veículo é obrigatória");
        }
    }
}
