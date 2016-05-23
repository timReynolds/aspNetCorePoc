using System.Threading.Tasks;

namespace POC.Application
{
    public interface IQueryHandler<in TQuery, TResult>
        where TQuery : IQuery<TResult> where TResult : Dto
    {
        Task<TResult> HandleAsync(TQuery dtoQuery);
    }
}