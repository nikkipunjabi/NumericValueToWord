using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace NumericValueToWord.Helper
{
    /// <summary>
    /// Reference: //https://stackoverflow.com/questions/43334034/convert-number-with-decimals-in-currency-to-words
    /// This helper class is accessed by the WebService
    /// </summary>
    public class WebServiceHelper
    {
        #region Public Method

        /// <summary>
        /// This function will be called by the Webservice to get Word from the given dollar value
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Returns string value of the given word in dollars</returns>
        public static string NumberToWordsDollar(int number)
        {
            if (number == 1)
            {
                var output = NumberToWords(number) + " dollar";
                output = Regex.Replace(output, @"\s+", " ");
                return output;
            }
            else
            {
                var output = NumberToWords(number) + " dollars";
                output = Regex.Replace(output, @"\s+", " ");
                return output;
            }
        }

        /// <summary>
        /// This function will be called by the Webservice to get Word from the given cent value
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string NumberToWordsCent(int number)
        {
            if (number == 1)
            {
                return NumberToWords(number) + " cent";
            }
            else
            {
                return NumberToWords(number) + " cents";
            }
        }

        /// <summary>
        /// This is the common function which will covert the given value to words.
        /// This will be used for Dollar and Cent
        /// This function can be called in recursion to calculate the smaller value first
        /// </summary>
        /// <param name="number"></param>
        /// <returns>word in string of the given integer</returns>
        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            var words = "";

            if (number / 1000000000 > 0)
            {
                words += NumberToWords(number / 1000000000) + " billion ";
                number %= 1000000000;
            }

            if (number / 1000000 > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if (number / 1000 > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if (number / 100 > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            words = SmallNumberToWord(number, words);

            return words;
        }

        /// <summary>
        /// This is for converting small number to words
        /// </summary>
        /// <param name="number"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        private static string SmallNumberToWord(int number, string words)
        {
            if (number <= 0) return words;
            if (words != "")
            {
                if (number > 0 && number <= 99)
                {
                    words += "and ";
                }
                else
                {
                    words += " ";
                }
            }

            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += "-" + unitsMap[number % 10];
            }
            return words;
        }

        #endregion
    }
}