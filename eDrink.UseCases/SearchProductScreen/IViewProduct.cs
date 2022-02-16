using eDrink.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDrink.UseCases.SearchProductScreen
{
    public interface IViewProduct
    {

        Product Execute(int id);
    }
}
