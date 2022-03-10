using NUnit.Framework;
using System.Collections.Generic;

namespace TestesFrancis.Exercicio1.Test
{
    public class HappyNumberGeneratorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void It_is_possible_to_validate_the_sum_of_numbers_generation_with_operation_or()
        {
            var happyNumberGenerator = new HappyNumberGenerator();
            var numerList = new List<int> { 3, 5 };

            var sum = happyNumberGenerator.OrGeneration(numerList, 10);

            Assert.IsTrue(sum == 23);
        }

        [Test]
        public void It_is_possible_to_validate_the_sum_of_numbers_generation_with_operation_and()
        {
            var happyNumberGenerator = new HappyNumberGenerator();
            List<int> numerList = new() { 3, 5 };

            var sum = happyNumberGenerator.AndGeneration(numerList, 46); //15, 30, 45 == 90

            Assert.IsTrue(sum == 90);
        }

        [Test]
        public void It_is_possible_to_validate_the_sum_of_numbers_generation_with_operation_or_and()
        {
            var happyNumberGenerator = new HappyNumberGenerator();
            var numerList = new List<int>();
            numerList.Add(3);
            numerList.Add(5);
            var sum = happyNumberGenerator.OrAndGeneration(numerList, 7, 36); //21, 35 == 56

            Assert.IsTrue(sum == 56);
        }
    }
}
