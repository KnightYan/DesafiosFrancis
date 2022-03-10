using System;
using System.Collections.Generic;
using TestesFrancis.Exercicio4.Dtos;
using TestesFrancis.Exercicio4.Models;

namespace TestesFrancis.Exercicio4.Interfaces
{
    public interface IShoppingCartService
    {
        void AddProduct(ProductDto product);
        void RemoveProduct(Guid productId);
        void ChangeProductQuantity(Guid productId, int newQuantity);
        List<ProductDto> GetProductShoppingList();
        void ClearShoppingList();
    }
}
