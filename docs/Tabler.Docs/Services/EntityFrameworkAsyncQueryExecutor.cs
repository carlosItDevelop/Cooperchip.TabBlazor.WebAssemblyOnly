using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using TabBlazor.Components.QuickTables.Infrastructure;

namespace Tabler.Docs.Services;

internal class EntityFrameworkAsyncQueryExecutor : IAsyncQueryExecutor
{
    public bool IsSupported<T>(IQueryable<T> queryable)
        => queryable.Provider is IAsyncQueryProvider;

    public Task<int> CountAsync<T>(IQueryable<T> queryable)
        => queryable.CountAsync();

    public Task<T []> ToArrayAsync<T>(IQueryable<T> queryable)
        => queryable.ToArrayAsync();
}