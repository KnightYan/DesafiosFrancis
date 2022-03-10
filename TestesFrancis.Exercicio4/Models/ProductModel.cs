using System;

namespace TestesFrancis.Exercicio4.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }

        public ProductModel(Guid id, string name, decimal value)
        {
            Id = id;
            Name = name;
            Value = value;
        }
    }
}
