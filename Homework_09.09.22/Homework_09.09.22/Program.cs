using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
#region 1ciTask
//namespace Task1
//{
//    class FirstTask
//    { 
//		static void Main(string[] args)
//        {
//            Thread thread = Thread.CurrentThread;
//            thread.Name = "Main Thread";
//            Console.WriteLine(thread.Name);

//            var secTread = new Thread(Method2);
//            secTread.Start();
//            Method1();
//            Method2();
//        }

//        static void Method1()
//        {
//            for (int i = 0; i < 50; i++)
//            {
//                Console.WriteLine("Method1: "+i);
//            }
//        }
//	    static void Method2()
//        {
//            for(int i = 0; i < 50; i++)
//            {
//                Console.WriteLine("Method2: "+i);
//            }
//        }
//	}
//}

#endregion
#region 2ciTask
//namespace Task2
//{
//    static async Task Main(string[] args)
//    {
//        string url = "https://catfact.ninja/fact";
//        HttpClient client = new HttpClient();
//        Console.WriteLine("Show me facts about cats");

//        do
//        {
//            var stringResult = await client.GetStringAsync(url);
//            Console.WriteLine(stringResult);
//        }
//        while (Convert.ToBoolean(Console.ReadLine()));
//    }
//}
#endregion
#region 3cuTask
//namespace Homework_09._09._22
//{
//    class Program
//    {
//        static int SumDigitsinString(string str)
//        {
//            var sum = 0;
//            for (var i = 0; i < str.Length; i++)
//            {
//                if (char.IsDigit(str[i]))
//                {
//                    sum += (int)char.GetNumericValue(str[i]);
//                }
//            }
//            return sum;
//        }

//        public static void Main()
//        {
//            Console.WriteLine(SumDigitsinString("1q2w3e")); //6 cixacaq.
//            Console.WriteLine(SumDigitsinString("L0r3m.1p5um")); //9 cixacaq.
//            Console.WriteLine(SumDigitsinString("")); //0 cixacaq.
//        }


//    }
//}
#endregion
#region 4cuTask
//namespace Task4
//{
//    class TopFiveNums
//    {
//        public static void Main(string[] args)
//        {
//            List<int> numbers = new List<int> { 78, -9, 0, 23, 54, 21, 7, 86 };
//            var top5 = numbers.OrderByDescending(x => x).Take(5);

//            foreach (var number in top5)
//            {
//                Console.WriteLine($"{number}");
//            }
//        }
//    }
//}
#endregion
#region 6ciTask
//namespace Task6
//{
//	class Task6
//	{
//		public static void Main()
//		{
//			int year = 2000;
//			Console.Write(checkYear(year) ? "Leap Year" :
//									"Not a Leap Year");
//		}
//		static bool checkYear(int year)
//		{

//			if (year % 400 == 0)
//				return true;

//			if (year % 100 == 0)
//				return false;

//			if (year % 4 == 0)
//				return true;
//			return false;
//		}
//	}
//}
#endregion
