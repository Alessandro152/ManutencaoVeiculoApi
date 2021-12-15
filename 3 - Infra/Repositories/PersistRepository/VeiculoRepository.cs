namespace ManutencaoVeiculoApi.Infra.Repositories.PersistRepository
{
    using ManutencaoVeiculoApi.Domain.Entities;
    using ManutencaoVeiculoApi.Domain.Interface.Repositories;
    using ManutencaoVeiculoApi.Infra.Context;
    using System;
    using System.Linq;

    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly DataBaseContext _context;

        public VeiculoRepository(DataBaseContext context)
        {
            _context = context;
        }

        public bool Add(Guid veiculoId, Guid clienteId, string marca, string modelo, string ano, string cor, string placa)
        {
            try
            {
                _context.veiculos.Add(new VeiculoModel() 
                { 
                    Id = veiculoId,
                    Marca = marca,
                    Modelo = modelo,
                    Ano = ano,
                    Cor = cor,
                    Placa = placa
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;
        }

        public bool Remove(Guid clienteId)
        {
            var entity = _context.veiculos.Where(x => x.Id == clienteId);
            _context.Remove(entity.FirstOrDefault());

            return true;
        }

        public bool Update(VeiculoModel veiculo)
        {
            _context.veiculos.Update(veiculo);
            return true;
        }
    }
}
