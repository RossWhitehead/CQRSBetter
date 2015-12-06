using System.Threading.Tasks;

namespace CQRSBetter.Infrastructure.Command
{
    public interface ICommandHandler<T> where T : ICommand
    {
        Task<CommandResult> HandleAsync(T command);
    }
}
