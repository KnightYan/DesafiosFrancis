using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesFrancis.Exercicio4.Dtos;

namespace TestesFrancis.Exercicio4.Interfaces
{
    public interface ICalculatorService
    {
        decimal Calculate(List<ProductDto> productShoppingList, int cep);
    }
}
