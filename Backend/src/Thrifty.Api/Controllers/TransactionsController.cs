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

        [HttpGet("all")]
        public async Task<ActionResult<IReadOnlyList<TransactionDto>>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _transactions.GetAllAsync(cancellationToken);
            return Ok(result);
        }

        [HttpGet("range")]
        public async Task<ActionResult<IReadOnlyList<TransactionDto>>> GetRange(string startDate, string endDate, CancellationToken cancellationToken)
        {
            
            var result = await _transactions.GetTransactionsRangeMonthAsync(startDate, endDate, cancellationToken);
            return Ok(result);
        }
    }
}
