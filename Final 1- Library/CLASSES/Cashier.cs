using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_1__Library.CLASSES
{
    internal class Cashier : EMPLOYEE
    {
       public override double Cal_Salary(int working_time,int extra)
       {
           int salary = 23 ;
            return (salary * working_time) + extra;
       }
    }
}
