using System;
using ClassLibrary1;
namespace mtpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input 1");
            String s1 = Console.ReadLine();
            Console.WriteLine("Input 2");
            String s2 = Console.ReadLine();

            int a = Convert.ToInt32(s1);
            int b = Convert.ToInt32(s2);

            Calculator calculator = new Calculator();
          
            int c = calculator.Add(a,b);
            //Console.WriteLine("Your answer : " +a+ "+"  +b+ "=" +c);
            string msg = $"Your Answer : {a} + {b} = {c}";
            Console.WriteLine(msg);
            Console.ReadLine();
        }
    }
}
