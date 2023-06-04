using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(evens => evens % 2 == 0).Sum() - numbers.Where(odds => odds % 2 !=0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strArray = new string[] { str1, str2, str3, str4 };

            int shortStr = strArray.Min(strItem => strItem.Length);

            return shortStr;

            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var intArray = new int[] { number1, number2, number3, number4 };

            return intArray.Min();
            
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) &&
            (sideLength3 + sideLength1 > sideLength2) &&
            (sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            var isNum = double.TryParse(input, out double number);
            return isNum;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var elemSize = objs.Length;
            var elem1 = (elemSize / 2 + 1);

            var nullElem = 0;

            foreach (var obj in objs) 
            {
                if (obj == null)
                {
                    nullElem++;
                }
            } 

            if (nullElem >= elem1)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var avgEvens = numbers.Where(nums => nums % 2 == 0);
                
            if (avgEvens.Count() == 0) 
            {
                return 0;
            
            }
            
            return avgEvens.Average();
              
            
            

        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            if (number == 0)
            {
                return 1;
            }

            var facto = number * Factorial(number - 1);


            return facto;
        }
    }
}
