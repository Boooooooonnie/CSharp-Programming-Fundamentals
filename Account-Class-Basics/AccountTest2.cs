using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0225上課
{
    class AccountTest2
    {
        static void Main()
        {
            Account2 myAccount2 = new Account2("Bonnie");
            Console.WriteLine($"Enter the name: {myAccount2.Name}");
            Console.WriteLine($"myAccount's name is: {myAccount2.Name}");
            Console.Read();
        }
    }
}
