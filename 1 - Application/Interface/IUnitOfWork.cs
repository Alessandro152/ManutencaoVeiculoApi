namespace ManutencaoVeiculoApi.Application.Interface
{
    public interface IUnitOfWork
    {
        public void Commit();

        public void RollBack();
    }
}
