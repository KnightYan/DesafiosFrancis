using NUnit.Framework;
using System.Collections.Generic;

namespace TestesFrancis.Exercicio1.Test
{
    public class MultipleNumberGeneratorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void It_is_possible_to_validate_numbers_generation_with_operation_or()
        {
            var numberGenerator = new MultipleNumberGenerator();
            var numerList = new List<int>();
            numerList.Add(3);
            numerList.Add(5);
            var generateList = numberGenerator.OrGenerationNumbers(numerList, 10);

            Assert.IsFalse(generateList.Contains(1));
            Assert.IsFalse(generateList.Contains(2));
            Assert.IsTrue(generateList.Contains(3));
            Assert.IsFalse(generateList.Contains(4));
            Assert.IsTrue(generateList.Contains(5));
            Assert.IsTrue(generateList.Contains(6));
            Assert.IsFalse(generateList.Contains(7));
            Assert.IsFalse(generateList.Contains(8));
            Assert.IsTrue(generateList.Contains(9));
            Assert.IsFalse(generateList.Contains(10));
        }

        [Test]
        public void It_is_possible_to_validate_numbers_generation_with_operation_and()
        {
            var numberGenerator = new MultipleNumberGenerator();
            var numerList = new List<int>();
            numerList.Add(3);
            numerList.Add(5);
            var generateList = numberGenerator.AndGenerationNumbers(numerList, 16);

            var multipleNumber = 15;

            for (int i = 1; i < multipleNumber; i++)
                Assert.IsFalse(generateList.Contains(i));

            Assert.IsTrue(generateList.Contains(multipleNumber));
        }

        [Test]
        public void It_is_possible_to_validate_numbers_generation_with_operation_or_and()
        {
            var numberGenerator = new MultipleNumberGenerator();
            var numerList = new List<int>();
            numerList.Add(3);
            numerList.Add(5);

            var andNumber = 7;
            var maxTestNumber = 36;

            var validMultipleNumbers = new List<int>();
            validMultipleNumbers.Add(21);
            validMultipleNumbers.Add(35);

            var generateList = numberGenerator.OrAndGenerationNumbers(numerList, andNumber, maxTestNumber);

            foreach (int number in generateList)
            {
                Assert.IsTrue(validMultipleNumbers.Contains(number));
            }
        }
    }
}
