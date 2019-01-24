using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractice
{
    class Program
    {
        public static Exception Work()
        {
            throw new Exception();
        }

        public static void Do()
        {
            try
            {
                Work();
            }
            catch (Exception)
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        }

        static void Main(string[] args)
        {
            Do();
            Console.ReadLine();
        }
    }
}
