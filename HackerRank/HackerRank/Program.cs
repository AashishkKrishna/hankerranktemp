using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.LinkedinQuestions;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1.LongestSequence();
        }

        #region Not Required as of now

        static void Main_Array_DS(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            if (n > 0)
                for (int i = n - 1; i >= 0; i--)
                    Console.Write(arr[i] + " ");

        }

        private static void Main_tobe(string[] args)
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
        }

        static void Main_test(string[] args)
        {
            int inputcombi = Convert.ToInt32(Console.ReadLine());
            char[] alphabets = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            List<Tuple<int, int, string>> lsttuple = new List<Tuple<int, int, string>>();
            for (int i = 0; i < inputcombi; i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                string palindrome = Console.ReadLine();

                lsttuple.Add(new Tuple<int, int, string>(Convert.ToInt32(arr_temp[0]),
                    Convert.ToInt32(arr_temp[1]), palindrome));
            }
            List<int> output = new List<int>();
            int palindromes = 0;
            List<int> lstpal = new List<int>();
            for (int j = 0; j < inputcombi; j++)
            {
                palindromes = 0;
                int n = lsttuple[j].Item1;
                int k = lsttuple[j].Item2;
                string checkstring = lsttuple[j].Item3;
                for (int i = 0; i < 26; i++)//26
                {
                    for (int m = 0; m <= checkstring.Length; m++)
                    {
                        string checkstringforpalindrome = checkstring;
                        char[] temp = checkstringforpalindrome.Insert(m, alphabets[i].ToString()).ToCharArray();
                        char[] reversestring = new char[temp.Length];
                        Array.Copy(temp, reversestring, temp.Length);

                        Array.Reverse(reversestring);
                        bool ispalindrome = true;
                        for (int o = 0; o < reversestring.Length; o++)
                        {
                            if (temp[o] != reversestring[o])
                            {
                                ispalindrome = false;
                            }
                        }
                        if (ispalindrome)
                        {
                            lstpal.Add(checkstringforpalindrome.Length);
                            palindromes++;
                        }
                    }

                }
                if (palindromes > k)
                {
                    output.Add(palindromes);
                }


            }

            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine(output[i]);
            }



        }

        static void Main_palindrome(string[] args)
        {
            int[] a = new[] { 31, 14, 15, 7, 2 };
            List<int> numberofones = new List<int>();
            int[] newarray = new int[a.Length];

            List<int> order = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                numberofones.Add(Convert.ToString(a[i], 2).Count(d => d == '1'));
            }
            for (int l = 0; l < a.Length; l++)
            {
                for (int i = 0; i < numberofones.Count - 1; i++)
                {
                    if (numberofones[i] > numberofones[i + 1])
                    {
                        newarray[i] = a[i];
                        newarray[i + 1] = a[i + 1];
                    }

                }
            }

            foreach (var ones in newarray)
            {
                Console.WriteLine(ones);
            }
        }

        static void Main_chalobbye(string[] args)
        {
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');



            bool ispresent = ransom.All(note => Array.IndexOf(magazine, note) >= 0);
            Console.WriteLine(ispresent ? "Yes" : "NO");
        }

        static void Main_Cutthesticks(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            while (arr.Length != 1)
            {
                if (!arr.Where(c => c != 0).Any()) break;
                Console.WriteLine(arr.Where(c => c != 0).Count());
                int min = arr.Where(c => c != 0).Min();
                arr = arr.Where(c => c != 0).Select(c => c - min).ToArray();


            }
        }

        static void Main_testing(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                string input_cw = Console.ReadLine();
                string output = new string(input_cw.ToCharArray().OrderByDescending(c => c).ToArray());
                if (input_cw == output)
                    Console.WriteLine("no answer");
                else
                    Console.WriteLine(output);
                n--;

            }
        }


        /// <summary>
        /// Question 1
        /// string input = "initialization";
        /// string output = nonRepeated(input);
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string nonRepeated(string s)
        {
            char[] a = s.ToCharArray();

            //Constraint: atleast there will be one non repeated character
            List<char> result = s.GroupBy(c => c).Select(c => new { c.Key, Count = c.Count() }).Where(c => c.Count < 2).Select(c => c.Key).ToList();
            int tempindex = 0;
            for (int i = 0; i < result.Count; i++)
            {
                int index = Array.IndexOf(a, result[i]);
                if (tempindex == 0)
                    tempindex = index;
                else if (index < tempindex)
                    tempindex = index;
            }
            return a[tempindex].ToString();
        }

        /// <summary>
        ///Question 2
        ///    int[] a = new[] { 6, 6, 3, 9, 3, 5, 1 };
        ///   int[] a = new[] { 1,3,46,1,3,9 };
        ///  int output = numberOfPairs(a, 47);
        /// </summary>
        /// <param name="a"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        static int numberOfPairs(int[] a, long k)
        {
            List<KeyValuePair<int, int>> tempdict = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] + a[j] == k)
                    {
                        if (!tempdict.Any(c => (c.Key == a[i] && c.Value == a[j]) || (c.Key == a[j] && c.Value == a[i])))
                            tempdict.Add(new KeyValuePair<int, int>(a[i], a[j]));
                    }
                }
            }

            return tempdict.Count();
        }

        /// <summary>
        /// Question3
        /// var result = braces(new string[2]);
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        static string[] braces(string[] values)
        {
            string[] output = new string[values.Length];

            char[] obrace = { '{', '[', '(' };
            char[] cbrace = { '}', ']', ')' };


            for (int i = 0; i < values.Length; i++)
            {
                char[] inputstring = values[i].ToCharArray();
                Stack<char> checkcharacters = new Stack<char>();

                foreach (char t in inputstring)
                {
                    if (obrace.Any(c => c == t))
                    {
                        checkcharacters.Push(t);
                    }
                    else if (cbrace.Any(c => c == t))
                    {
                        if (checkcharacters.Count != 0)
                        {
                            if (t == ')' && '(' != checkcharacters.Pop())
                            {
                                output[i] = "NO";
                                break;
                            }
                            if (t == '}' && '{' != checkcharacters.Pop())
                            {
                                output[i] = "NO";
                                break;
                            }
                            if (t == ']' && '[' != checkcharacters.Pop())
                            {
                                output[i] = "NO";
                                break;
                            }
                        }
                        else
                        {
                            output[i] = "NO";
                            break;
                        }
                    }
                    else
                    {
                        output[i] = "NO";
                        break;
                    }
                }
                if (checkcharacters.Count == 0)
                    output[i] = "YES";
                else
                    output[i] = "NO";

            }

            return output;
        } 
        #endregion

    }
}


