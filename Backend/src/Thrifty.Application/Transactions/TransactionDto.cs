using Thrifty.Domain.Entities;
using Thrifty.Domain.Enums;

namespace Thrifty.Application.Transactions;

// Shape matches the Transaction interface in Frontend/src/types/index.ts.
public record TransactionDto(
    string Id,
    DateOnly Date,
    string Merchant,
    string? Note,
    CategoryId Category,
    string PaymentMethod,
    decimal Amount)
{
    public static TransactionDto FromEntity(Transaction t) =>
        new(t.Id.ToString(), t.Date, t.Merchant, t.Note, t.Category, t.PaymentMethod, t.Amount);
}
