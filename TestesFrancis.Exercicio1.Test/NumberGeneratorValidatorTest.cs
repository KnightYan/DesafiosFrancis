using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace TestesFrancis.Exercicio1.Test
{
    public class NumberGeneratorValidatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void It_is_possible_to_validate_multiple_numbers_with_operation_or()
        {
            var numberGeneratorValidator = new NumberGeneratorValidator();
            var numerList = new List<int>();
            numerList.Add(3);
            numerList.Add(5);

            Assert.IsFalse(numberGeneratorValidator.OrValidation(1, numerList));
            Assert.IsFalse(numberGeneratorValidator.OrValidation(2, numerList));
            Assert.IsTrue(numberGeneratorValidator.OrValidation(3, numerList));
            Assert.IsFalse(numberGeneratorValidator.OrValidation(4, numerList));
            Assert.IsTrue(numberGeneratorValidator.OrValidation(5, numerList));
            Assert.IsTrue(numberGeneratorValidator.OrValidation(6, numerList));
            Assert.IsFalse(numberGeneratorValidator.OrValidation(7, numerList));
            Assert.IsFalse(numberGeneratorValidator.OrValidation(8, numerList));
            Assert.IsTrue(numberGeneratorValidator.OrValidation(9, numerList));
            Assert.IsTrue(numberGeneratorValidator.OrValidation(10, numerList));
        }

        [Test]
        public void It_is_possible_to_validate_multiple_numbers_with_operation_and()
        {
            var numberGeneratorValidator = new NumberGeneratorValidator();
            var numerList = new List<int>();
            numerList.Add(3);
            numerList.Add(5);
            var multipleNumber = 15;

            for (int i = 1; i < multipleNumber; i++)
                Assert.IsFalse(numberGeneratorValidator.AndValidation(i, numerList));

            Assert.IsTrue(numberGeneratorValidator.AndValidation(multipleNumber, numerList));
        }

        [Test]
        public void It_is_possible_to_validate_multiple_numbers_with_operation_or_and()
        {
            var numberGeneratorValidator = new NumberGeneratorValidator();
            var orNumerList = new List<int>();
            orNumerList.Add(3);
            orNumerList.Add(5);
            var andNumber = 7;
            var maxTestNumber = 100;

            for (int i = 1; i < maxTestNumber; i++)
            {
                if (orNumerList.Any(x => i % x == 0 && i % andNumber == 0))
                    Assert.IsTrue(numberGeneratorValidator.OrAndValidation(i, orNumerList, andNumber));
                else
                    Assert.IsFalse(numberGeneratorValidator.OrAndValidation(i, orNumerList, andNumber));
            }
        }
    }
}