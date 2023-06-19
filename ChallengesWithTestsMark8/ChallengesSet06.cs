using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if(string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }


            if(ignoreCase == true) 
            {
                word = word.ToLower();

                List<string> lowcase = words.Select(lc => lc.ToLower()).ToList();

                containsWord = lowcase.Contains(word);
            }

            if(ignoreCase == false) 
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            var itsPrime = false;

            if(num >= 0) 
            {
                if(num % 2 != 0 && num % 3 != 0)
                {
                    itsPrime = true;
                }    
            }

            if((num == 2) || (num == 3))
            {
                itsPrime = true;
            }

            if(num == 1)
            {
                itsPrime = false;
            }

            return itsPrime;    
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;

            bool uindex;

            for(int i = 0; i <str.Length; i++)
            {
                uindex = true;

                for(int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uindex = false;
                    }
                }

                if(uindex == true)
                {
                    index = i;
                }
            }
            return index;
        }   


        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (var i = 0; i < numbers.Length; i++) 
            {
                int currCount = 1;

                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currCount++;
                }

                if(currCount > count)
                {
                    count = currCount;
                }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nthElement = new List<double>();

            if(elements == null || n<=0 || n > elements.Count)
            {
                return nthElement.ToArray();
            }

            for (var i = n -1; i < elements.Count; i += n)
            {
                nthElement.Add(elements[i]);
            }

            return nthElement.ToArray();
        }
    }
}
