using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Console
{
    class Program
    {
        public static void Main(string[] args)
        {
            PasswordCheckerService checker = new PasswordCheckerService(new SqlRepository(), new DefaultValidator1(), new DefaultValidator2());
            System.Console.WriteLine(checker.VerifyPassword(string.Empty).Item2);
            System.Console.WriteLine(checker.VerifyPassword("123456").Item2);
            System.Console.WriteLine(checker.VerifyPassword("123afffffffffffffff").Item2);
            System.Console.WriteLine(checker.VerifyPassword("78003560").Item2);
            System.Console.ReadKey();
        }
    }
}
