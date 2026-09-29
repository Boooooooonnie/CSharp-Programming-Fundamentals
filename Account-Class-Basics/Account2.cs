using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0225上課
{
    class Account2
    {
        public string Name { get; set; }
        public Account2(string accountName)
        {
            Name = accountName;
        }
        public Account2() { } 
        //需加上無建構函數(若沒有在程式碼內宣告name=bonnie)
    }
}
