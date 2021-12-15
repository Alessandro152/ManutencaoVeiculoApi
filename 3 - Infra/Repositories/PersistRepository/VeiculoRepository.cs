namespace ManutencaoVeiculoApi.Infra.Repositories.PersistRepository
{
    using ManutencaoVeiculoApi.Application.Interface;
    using ManutencaoVeiculoApi.Domain.Entities;
    using System;

    public class VeiculoRepository : IVeiculoRepository
    {
        public VeiculoRepository()
        {

        }

        public bool Add(Guid clienteId, string marca, string modelo, string ano, string cor, string placa)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public bool Update(VeiculoModel veiculo)
        {
            throw new NotImplementedException();
        }
    }
}
