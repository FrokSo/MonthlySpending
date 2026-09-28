using Thrifty.Application.Abstractions;

namespace Thrifty.Application.Transactions
{
    public class TransactionService
    {
        private readonly ITransactionRepository _transactions;

        public TransactionService(ITransactionRepository transactions)
        {
            _transactions = transactions;
        }

        public async Task<IReadOnlyList<TransactionDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var entities = await _transactions.GetAllAsync(cancellationToken);
            return entities.Select(TransactionDto.FromEntity).ToList();
        }
    }
}
