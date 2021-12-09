using ManutencaoVeiculoApi.Application.AppServices.Cliente;
using ManutencaoVeiculoApi.Application.ViewModel;
using ManutencaoVeiculoApi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManutencaoVeiculoApi.Controllers
{
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
        public async Task SalvarCliente(ClienteViewModel dados)
        {
            var cliente = new ClienteModel
            {
                Id = Guid.NewGuid(),
                Nome = dados.Nome,
                Endereco = dados.Endereco,
                EMail = dados.EMail,
                Telefone = dados.Telefone,
                Veiculo = dados.Veiculo as IEnumerable<VeiculoModel>
            };

            await _clienteService.SalvarCliente(cliente).ConfigureAwait(false);
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
