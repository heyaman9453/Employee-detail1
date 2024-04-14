using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace employee_detail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the employee name Id ");
            int employeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the employee name ");
            string fullName = Console.ReadLine();
            Console.WriteLine("enetr the employee salary ");
            double salary = int.Parse(Console.ReadLine());
            Console.ReadLine();
        }
    }
}