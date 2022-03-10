using System.Collections.Generic;
using System.Linq;

namespace TestesFrancis.Exercicio1
{
    public class NumberGeneratorValidator
    {
        public bool OrValidation(int multipleNumber, List<int> baseNumbers)
        {
            return baseNumbers.Any(x => multipleNumber % x == 0);
        }

        public bool AndValidation(int multipleNumber, List<int> baseNumbers)
        {
            return baseNumbers.Count(x => multipleNumber % x == 0) == baseNumbers.Count();
        }

        public bool OrAndValidation(int multipleNumber, List<int> orNumbers, int andNumber)
        {
            return orNumbers.Any(x => multipleNumber % x == 0 && multipleNumber % andNumber == 0);
        }
    }
}
