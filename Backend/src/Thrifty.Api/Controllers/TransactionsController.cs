using Microsoft.AspNetCore.Mvc;
using Thrifty.Application.Transactions;

namespace Thrifty.Api.Controllers
{
    [ApiController]
    [Route("api/transactions")]
    public class TransactionsController : ControllerBase
    {
        private readonly TransactionService _transactions;

        public TransactionsController(TransactionService transactions)
        {
            _transactions = transactions;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<TransactionDto>>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _transactions.GetAllAsync(cancellationToken);
            return Ok(result);
        }
    }
}
