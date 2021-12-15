using ManutencaoVeiculoApi.Domain.Enum;
using System;

namespace ManutencaoVeiculoApi.Domain.Commands.Veiculo
{
    public class VeiculoCommand : Command
    {

        public VeiculoCommand(Guid clienteId, string marca, string modelo, string ano, VeiculoTipo tipo, string cor, string placa)
        {
            ClienteId = clienteId;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Tipo = tipo;
            Cor = cor;
            Placa = placa;
        }

        public Guid ClienteId { get; }

        public string Marca { get; }

        public string Modelo { get; }

        public string Ano { get; }

        public VeiculoTipo Tipo { get; }

        public string Cor { get; }

        public string Placa { get; }
    }
}
