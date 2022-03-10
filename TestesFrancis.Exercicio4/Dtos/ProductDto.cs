using System;

namespace TestesFrancis.Exercicio4.Dtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }

        public ProductDto(Guid id, string name, decimal value, int quantity)
        {
            Id = id;
            Name = name;
            Value = value;
            Quantity = quantity;
        }
    }
}