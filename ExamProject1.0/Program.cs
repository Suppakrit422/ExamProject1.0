using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExamProject1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = null;
            
            Console.WriteLine("=====Test 1.0 =====\n");
            
            result =  ExtractNumbers("10,20,AAA,-5");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=====Test 2.0 =====\n");
            RandomFunction();
        }

        #region function

        public static int[] ExtractNumbers(string input)
        {
            List<int> ListInt = new List<int>();
            int[] ExportRusult=null;string[] Result = null;
            Result = input.Split(',');

            foreach (var item in Result)
            {
                bool check = false;
                
                Regex pattern1 = new Regex(@"^([+-]?[0-9]\d*|0)$");
                check = pattern1.IsMatch(item) ? true : false;

                if (check)
                {
                    ListInt.Add(int.Parse(item));
                }
            }
        
            return ListInt.ToArray();
        }

        public static void RandomFunction()
        {
            Random rnd = new Random();
            
            int i = 0;
            while (i < 15)
            {
                int x = rnd.Next(1, 10);

                if (x%2 == 0)
                {
                    Console.WriteLine(x+ " EVEN");
                }
                else
                {
                    Console.WriteLine(x + " ODD");
                }
                i++;
            }
        }


        #endregion

    }
}
