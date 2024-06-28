using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TabBlazor;
using TabBlazor.Components.QuickTables;

public interface IDataService
{
    Task<GridItemsProviderResult<TabBlazor.Country>> GetCountriesAsync(int startIndex, int? count, string sortBy, bool sortAscending, CancellationToken cancellationToken);

    IQueryable<Country> Countries { get; }
}