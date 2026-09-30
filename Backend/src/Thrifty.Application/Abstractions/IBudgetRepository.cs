using System;
using System.Collections.Generic;
using System.Text;
using Thrifty.Domain.Entities;


namespace Thrifty.Application.Abstractions
{
    public interface IBudgetRepository
    {
        Task<IReadOnlyList<Budget>> GetByMonthAsync(int year, int month, CancellationToken cancellationToken = default);

    }
}
