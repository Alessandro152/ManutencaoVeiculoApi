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
        [Route("/GetCliente")]
        public ClienteViewModel RetornarCliente()
        {
            return new ClienteViewModel();
        }

        [HttpPost]
        [Route("/SaveCliente")]
        public async Task<IActionResult> SalvarCliente(ClienteViewModel cliente)
        {
            var dados = new ClienteModel()
            {
                Nome = cliente.Nome,
                EMail = cliente.EMail,
                Telefone = cliente.Telefone,
                Endereco = cliente.Endereco,
                Veiculo = (IEnumerable<VeiculoModel>)cliente.Veiculo
            };

            await _clienteService.SalvarCliente(dados).ConfigureAwait(false);

            return Created("", dados);
        }

        [HttpPut]
        public IActionResult AlterarAgendamentoManutencao([FromBody] ManutencaoModel dados)
        {
            return Ok();
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
