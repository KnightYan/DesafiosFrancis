using System;
using System.Collections.Generic;

namespace TestesFrancis.Exercicio2
{
    public class HappyNumberDetector
    {
        private readonly List<int> numberHistory;
        public HappyNumberDetector()
        {
            numberHistory = new List<int>();    
        }

        public bool IsTheNumberHappy(int number)
        {
            numberHistory.Clear();

            try
            {
                return CheckHappyNumber(number);
            }
            catch(DuplicateValueException)
            {
                return false;
            }
        }

        private bool CheckHappyNumber(int number)
        {
            AddNumberToHistory(number);

            if (number == 1)
                return true;

            return CheckHappyNumber(CalculateNextNumber(number));
        }

        private void AddNumberToHistory(int number)
        {
            if(numberHistory.Contains(number))
                throw new DuplicateValueException();

            numberHistory.Add(number);
        }

        private int CalculateNextNumber(int number)
        {
            var numbersText = number.ToString();
            int newNumber = 0;

            foreach(char aux in numbersText)
            {
                newNumber += Convert.ToInt32(Math.Pow(CharToInt(aux), 2));
            }

            return newNumber;

        }

        private static int CharToInt(char aux)
        {
            return Convert.ToInt32(aux.ToString());
        }
    }
}
