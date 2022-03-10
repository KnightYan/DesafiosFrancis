using Moq;
using System;
using System.Collections.Generic;
using TestesFrancis.Exercicio4.Dtos;
using TestesFrancis.Exercicio4.Interfaces;
using TestesFrancis.Exercicio4.Services;
using Xunit;

namespace TestesFrancis.Exercicio4.Tests
{
    public class CalculatorServiceTests : BaseTest , IDisposable
    {
        private readonly CalculatorService calculatorService;
        private const decimal shippingCostTest = 50;
        private const int productTestNewQuantity = 1;
        private List<ProductDto> productListTest;

        //ARRANGE
        public CalculatorServiceTests() : base()
        {
            Mock<ICorreioService> mock = new();
            mock.Setup(x => x.CalculateShipping(It.IsAny<int>())).Returns(shippingCostTest);

            calculatorService = new CalculatorService(mock.Object);

            GenerateProductList();
        }

        private void GenerateProductList()
        {
            productListTest = new List<ProductDto>() { productTest1, productTest2 };
        }

        public void Dispose()
        {
            GenerateProductList();
        }

        //ACT + ASSERT
        [Fact]
        public void Calculate_Validate_Null_Product_List_Exception()
        {
            Assert.Throws<ArgumentNullException>(() => calculatorService.Calculate(null, userTest.Cep));
        }

        //ACT
        [Fact]
        public void Calculate_Validate_Empty_Product_List()
        {
            var calculateValue = calculatorService.Calculate(new List<ProductDto>(), userTest.Cep);

            Validade_The_Calculate_Value(0, calculateValue);
        }

        //ACT
        [Fact]
        public void Calculate_Validate_Free_Value()
        {
            var calculateValue = calculatorService.Calculate(productListTest, userTest.Cep);

            decimal totalValue = productTest1Value * productTest1Quantity;
            totalValue += productTest2Value * productTest2Quantity;

            Validade_The_Calculate_Value(totalValue, calculateValue);
        }

        //ACT
        [Fact]
        public void Calculate_Validate_Value_With_Shipping()
        {
            foreach (var product in productListTest)
            {
                product.Quantity = productTestNewQuantity;
            }

            decimal totalValue = productTest1Value + productTest2Value + shippingCostTest;

            var calculateValue = calculatorService.Calculate(productListTest, userTest.Cep);

            Validade_The_Calculate_Value(totalValue, calculateValue);
        }

        //ASSERT
        private void Validade_The_Calculate_Value(decimal ExpectedValue, decimal CalculateValue)
        {
            Assert.Equal(ExpectedValue, CalculateValue);
        }


    }
}
