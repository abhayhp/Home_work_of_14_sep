using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_of_14_sep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp1 = new Emp(3, "abhay", 105000);
            emp1.CalculateSalary();
            emp1.TotalSalary();
            emp1.NetPaidsalary();
            emp1.Print();
        }
    }
}
