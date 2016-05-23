using System.Threading.Tasks;

namespace POC.Application
{
    public interface ICommandHandler<in TCommand, out TResult>
        where TCommand : ICommand
        where TResult : Dto
    {
        TResult Result { get; }

        Task HandleAsync(TCommand command);
    }
}