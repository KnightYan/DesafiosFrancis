using System.Collections.Generic;

namespace TestesFrancis.Exercicio1
{
    public class MultipleNumberGenerator
    {
        private readonly NumberGeneratorValidator validator;
        public MultipleNumberGenerator()
        {
            validator = new NumberGeneratorValidator();
        }

        public List<int> OrGenerationNumbers(List<int> baseNumbers, int limitNumber)
        {
            var resultNumbers = new List<int>();
            for (int i = 1; i < limitNumber; i++)
            {
                if (validator.OrValidation(i, baseNumbers))
                    resultNumbers.Add(i);
            }

            return resultNumbers;
        }
        
        public List<int> AndGenerationNumbers(List<int> baseNumbers, int limitNumber)
        {
            var resultNumbers = new List<int>();
            for(int i= 1; i < limitNumber; i++)
            {
                if (validator.AndValidation(i, baseNumbers))
                    resultNumbers.Add(i);
            }

            return resultNumbers;
        }

        public List<int> OrAndGenerationNumbers(List<int> orNumbers, int andNumber, int limitNumber)
        {
            var resultNumbers = new List<int>();
            for (int i = 1; i < limitNumber; i++)
            {
                if (validator.OrAndValidation(i, orNumbers, andNumber))
                    resultNumbers.Add(i);
            }

            return resultNumbers;
        }
    }
}
