using System;
using TestesFrancis.Exercicio4.Dtos;
using TestesFrancis.Exercicio4.Models;

namespace TestesFrancis.Exercicio4.Tests
{
    public class BaseTest
    {
        protected UserModel userTest;

        protected ProductDto productTest1;
        protected const decimal productTest1Value = 10;
        protected const int productTest1Quantity = 5;

        protected ProductDto productTest2;
        protected const decimal productTest2Value = 20;
        protected const int productTest2Quantity = 10;

        public BaseTest()
        {
            GenerateUser();
            GenerateProdutos();
        }

        protected void GenerateProdutos()
        {
            productTest1 = new ProductDto(Guid.NewGuid(), Faker.RandomNumber.Next().ToString(), productTest1Value, productTest1Quantity);
            productTest2 = new ProductDto(Guid.NewGuid(), Faker.RandomNumber.Next().ToString(), productTest2Value, productTest2Quantity);
        }
        
        protected void GenerateUser()
        {
            userTest = new UserModel(Guid.NewGuid(), Faker.Name.First(), Faker.RandomNumber.Next());
        }
    }
}
