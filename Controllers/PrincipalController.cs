using ManutencaoVeiculoApi.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ManutencaoVeiculoApi.Controllers
{
    public class PrincipalController : Controller
    {
        [HttpGet]
        public IList<VeiculoViewModel> RetornarTodosVeiculos()
        {
            return new List<VeiculoViewModel>();
        }

        [HttpGet]
        public ClienteViewModel RetornarCliente()
        {
            return new ClienteViewModel();
        }

        [HttpPut]
        public bool AlterarAgendamentoManutencao([FromBody] ManutencaoModel dados)
        {
            return true;
        }

        [HttpPost]
        public bool AgendarManutencao([FromBody] ManutencaoModel dados)
        {
            return true;
        }

        [HttpDelete]
        public bool RemoverAgendamento([FromBody] int id)
        {
            return true;
        }
    }
}
