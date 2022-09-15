using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_of_14_sep
{
    public class Emp
    {
        int empid;
        string empname;
        double bs, hra, da, pf, total_allowance, total_salary, net_paid_salary;       
        double pt = 200;
        

        public Emp(int empid, string empname, double bs)
        {
            this.empid = empid;
            this.empname = empname;
            this.bs = bs;
        }

        public void CalculateSalary()
        {
            hra = (40.0 / 100.0) * bs;
            da = (20.0 / 100.0) * bs;
            pf = (12.0 / 100.0) * bs;
            total_allowance = hra + da;
        }

        public void TotalSalary()
        {
            total_salary = bs + total_allowance;
        }

        public void NetPaidsalary()
        {
            net_paid_salary = total_salary - (pf + pt);
        }

        public void Print()
        {
            
            Console.WriteLine("Empname : " + empname + "\n" + "empid : " + empid + "\n" +
                "total_salary : " + total_salary + "\n" + "Net-paid salary : " + net_paid_salary);
               
        }
    }
}
