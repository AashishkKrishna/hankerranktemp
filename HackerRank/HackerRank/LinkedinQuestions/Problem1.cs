using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.LinkedinQuestions
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/linkedin-practice-dynamic-programming-lcs
    /// </summary>
    public class Problem1
    {
        public static void LongestSequence()
        {
            int[] inputarraysizes = Array.ConvertAll(Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);

            int[] minelementarray = new int[inputarraysizes.Min()], maxelearray = new int[inputarraysizes.Max()];
            int flag = 1, i = 0;
            for (i = 0; i < inputarraysizes.Length; i++)
            {
                if (Array.IndexOf(inputarraysizes, inputarraysizes.Min()) == 0 && flag == 1)
                {
                    minelementarray = Array.ConvertAll(Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
                    flag = 2;
                }
                else
                {
                    maxelearray = Array.ConvertAll(Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
                }
            }

            int startpositionofmin = 0, startpositionofmax = 0;
            int currentpositionofmin = 0, currentpositionofmax = 0;

            while (startpositionofmin < minelementarray.Length)
            {
                currentpositionofmin = startpositionofmin;
                currentpositionofmax = 0;

                while (currentpositionofmin < minelementarray.Length)
                {
                    if (maxelearray[currentpositionofmax] == minelementarray[currentpositionofmin])
                    {

                    }
                    currentpositionofmax++;
                    currentpositionofmin++;
                }
            }
        }
    }
}
