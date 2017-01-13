using System;

namespace FirstAppVS2015
{
    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string WriteName(string name)
        {
            return name;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringArray"></param>
        /// <returns></returns>
        public string combineArrayStringWithSpace(string[] stringArray)
        {
            string str = default(string);

            foreach (string item in stringArray)
            {
                str += item + " ";
            }

            return str.Trim();
        }

        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
