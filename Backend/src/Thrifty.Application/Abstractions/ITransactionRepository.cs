using Thrifty.Domain.Entities;

namespace Thrifty.Application.Abstractions
{
    public interface ITransactionRepository
    {
        Task<IReadOnlyList<Transaction>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IReadOnlyList<Transaction>> GetTransactionsByMonthAsync(string date, CancellationToken cancellationToken = default);

    }
}
