using eDrink.Core.Models;

namespace eDrink.UseCases.SearchProductScreen
{

    public interface ISearchProduct
    {

        IEnumerable<Product> Execute(string filter = null);
    }
}
