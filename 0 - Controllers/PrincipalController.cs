namespace ManutencaoVeiculoApi.Controllers
{
    using ManutencaoVeiculoApi.Application.AppServices.Cliente;
    using ManutencaoVeiculoApi.Application.ViewModel;
    using ManutencaoVeiculoApi.Domain.Entities;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class PrincipalController : Controller
    {
        private readonly ClienteService _clienteService;

        public PrincipalController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

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

        [HttpPost]
        public async Task SalvarCliente(ClienteModel dados)
        {
            await _clienteService.SalvarCliente(dados).ConfigureAwait(false);
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
        public bool RemoverAgendamento([FromBody] Guid clienteId)
        {
            return true;
        }
    }
}
