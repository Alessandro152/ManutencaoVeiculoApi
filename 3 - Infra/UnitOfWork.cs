namespace ManutencaoVeiculoApi.Infra
{
    using ManutencaoVeiculoApi.Application.Interface;
    using ManutencaoVeiculoApi.Infra.Context;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataBaseContext _context;

        public UnitOfWork(DataBaseContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChangesAsync();
        }

        public void RollBack()
        {
            //GC Act
        }
    }
}
