using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TabBlazor.Components.QuickTables;

public interface IDataService
{
    Task<GridItemsProviderResult<TabBlazor.Country>> GetCountriesAsync(int startIndex, int? count, string sortBy, bool sortAscending, CancellationToken cancellationToken);

    IQueryable<TabBlazor.Country> Countries { get; }
}