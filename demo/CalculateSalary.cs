//10.Write a C# program to input basic salary of an employee and calculate its  
//Gross salary according to following: Basic Salary <= 10000 : HRA = 20 %, DA = 80 % Basic Salary <= 20000 : HRA = 25 %, 
//DA = 90 % Basic Salary > 20000 : HRA = 30 %, DA = 95 %


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class CalculateSalary
    {
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter basic salary of employee");
        //    double basicSal=Convert.ToDouble(Console.ReadLine());

        //    double hra, da, grossSal;

        //    if(basicSal <= 10000)
        //    {
        //        hra = 0.02 * basicSal;
        //        da = 0.80 * basicSal;
        //    }
        //    else if(basicSal <= 20000)
        //    {
        //        hra = 0.25 * basicSal;
        //        da = 0.90 * basicSal;
        //    }
        //    else
        //    {
        //        hra = 0.30 * basicSal;
        //        da = 0.95 * basicSal;
        //    }

        //    grossSal = basicSal + hra + da;

        //    Console.WriteLine($"basic salary :{basicSal}");
        //    Console.WriteLine($"DA:{da}");
        //    Console.WriteLine($"HRA:{hra}");
        //    Console.WriteLine($"Gross Salary:{grossSal}");
        //}
    }
}
