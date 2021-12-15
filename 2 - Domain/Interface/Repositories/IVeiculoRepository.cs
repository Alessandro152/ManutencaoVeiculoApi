namespace ManutencaoVeiculoApi.Domain.Interface.Repositories
{
    using ManutencaoVeiculoApi.Domain.Entities;
    using System;

    public interface IVeiculoRepository
    {
        bool Update(VeiculoModel veiculo);

        bool Remove(Guid clienteId);

        bool Add(Guid veiculoId, Guid clienteId, string marca, string modelo, string ano, string cor, string placa);
    }
}
