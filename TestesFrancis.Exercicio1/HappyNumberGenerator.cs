using System.Collections.Generic;
using System.Linq;

namespace TestesFrancis.Exercicio1
{
    public class HappyNumberGenerator
    {
        public int OrGeneration(List<int> numbers, int limitNumber)
        {
            var numberGenerate = new MultipleNumberGenerator();

            return numberGenerate.OrGenerationNumbers(numbers, limitNumber).Sum();

        }

        public int AndGeneration(List<int> numbers, int limitNumber)
        {
            var numberGenerate = new MultipleNumberGenerator();

            return numberGenerate.AndGenerationNumbers(numbers, limitNumber).Sum();
        }

        public int OrAndGeneration(List<int> orNumbers, int andNumber, int limitNumber)
        {
            var numberGenerate = new MultipleNumberGenerator();

            return numberGenerate.OrAndGenerationNumbers(orNumbers, andNumber, limitNumber).Sum();
        }
    }
}
