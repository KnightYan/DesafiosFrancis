namespace TestesFrancis.Exercicio4.Models
{
    public class ProductCartModel 
    {
        public ProductModel Product { get; set; }
        public int Quantity { get; set; }

        public ProductCartModel(ProductModel product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
