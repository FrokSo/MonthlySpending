using Microsoft.AspNetCore.Mvc;
using Thrifty.Application.Transactions;

namespace Thrifty.Api.Controllers;

[ApiController]
[Route("api/transactions")]
public class TransactionsController(TransactionService transactions) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<TransactionDto>>> GetAll(CancellationToken cancellationToken) =>
        Ok(await transactions.GetAllAsync(cancellationToken));
}
