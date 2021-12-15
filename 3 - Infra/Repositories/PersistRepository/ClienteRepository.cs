namespace ManutencaoVeiculoApi.Infra.Repositories.PersistRepository
{
    using ManutencaoVeiculoApi.Domain.Commands;
    using ManutencaoVeiculoApi.Domain.Interface.Repositories;
    using ManutencaoVeiculoApi.Infra.Context;
    using System;

    public class ClienteRepository : IClienteRepository
    {
        private readonly DataBaseContext _context;

        public ClienteRepository(DataBaseContext context)
        {
            _context = context;
        }

        public bool Add(ClienteCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
