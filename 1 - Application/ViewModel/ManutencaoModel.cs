using ManutencaoVeiculoApi.Domain.Entities;
using System.Collections.Generic;

namespace ManutencaoVeiculoApi.Application.ViewModel
{
    public class ManutencaoModel
    {
        public ClienteModel Cliente { get; set; }

        public IList<VeiculoModel> Veiculo { get; set; }
    }
}
