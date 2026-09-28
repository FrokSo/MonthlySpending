using Thrifty.Application.Abstractions;

namespace Thrifty.Application.Transactions;

public class TransactionService(ITransactionRepository transactions)
{
    public async Task<IReadOnlyList<TransactionDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var entities = await transactions.GetAllAsync(cancellationToken);
        return entities.Select(TransactionDto.FromEntity).ToList();
    }
}
