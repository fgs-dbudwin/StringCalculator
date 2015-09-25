using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculator.Src
{
    public class Calculator
    {
        private const int LARGEST_VALID_NUMBER = 1000;

        public int Add(string numbers)
        {
            string csvNumbers = Regex.Replace(numbers, "[^-0-9]", ",");

            string[] splitNumbers = csvNumbers.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            int[] individualNumbers = splitNumbers.Select(number => Convert.ToInt32(number)).ToArray();
            int[] negativeNumbers = individualNumbers.Where(num => num < 0).ToArray();
            int[] validPositiveNumbers = individualNumbers.Where(num => (num > 0) && (num <= LARGEST_VALID_NUMBER)).ToArray();

            CheckForNegatives(negativeNumbers);

            return validPositiveNumbers.Sum();
        }

        private void CheckForNegatives(int[] negatives)
        {
            if (negatives.Length > 0)
            {
                throw new System.Exception("Negatives not allowed: " + string.Join(", ", negatives));
            }
        }
    }
}
