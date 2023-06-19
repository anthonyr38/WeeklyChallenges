using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(var biz = 0; biz < businesses.Length; biz++)
            {
                if (businesses[biz].TotalRevenue == 0) 
                {
                    businesses[biz].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0) 
            {
                return false;
            }


            for(var num = 1; num < numbers.Length; num++) 
            {
                if (numbers[num] < numbers[num - 1]) 
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;

            for(int sumnum = 1; sumnum < numbers.Length; sumnum++)
            {
                if (numbers[sumnum-1] % 2 == 0) 
                {
                    sum += numbers[sumnum];
                }
            }
            return sum; 
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words == null || words.Length == 0) 
            {
                return "";
            }

            string sentence = "";

            foreach(string word in words) 
            {
                if(word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }

            if(sentence.Length == 0)
            {
                return "";
            }
            sentence = sentence.Trim();
            sentence += ".";
            return sentence;
           
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if(elements == null || elements.Count == 0) 
            {
                return new double[0];
            }

            List<double> evfouthEl = new List<double>();

            for(var evFourth = 3; evFourth < elements.Count; evFourth += 4) 
            {
                evfouthEl.Add(elements[evFourth]);
            }
            return evfouthEl.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int num = 0; num < nums.Length; num++) 
            {
                for(int numb = num + 1; numb < nums.Length; numb++) 
                {
                    if (nums[num] + nums[numb] == targetNumber) 
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
