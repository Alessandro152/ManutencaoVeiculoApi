using ManutencaoVeiculoApi.Domain.Commands;
using System.Threading.Tasks;

namespace ManutencaoVeiculoApi.Domain.Interface
{
    public interface IHandler<in TMessage> where TMessage : Command
    {
        Task<bool> Handle(TMessage message);
    }
}
