using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_exercise
{
    class Employee
    {
        private string first;
        private string last;
        private string pos;
        private int exp;
        private int okl;
        private int sbir = 20;

        public Employee(string firstName, string lastName)
        {
            first = firstName;
            last = lastName;
        }

        public void Rozrahunok()
        {
            if (pos == "junior" || pos == "Junior" && exp <= 1)
            {
                okl = 1000;
            }
            else if (pos == "middle" || pos == "Middle" && exp <= 4 && 1 <= exp)
            {
                okl = 3000;
            }
            else if (pos == "senior" || pos == "Senior" && 4 <= exp)
            {
                okl = 5000;
            }
            else
            {
                pos = "trainee";
                exp = 0;
                okl = 500;
            }
        }


        public void Write()
        {
            Console.WriteLine($"Name: {first} \nLast Name: {last} \nPosition: {pos} \nExpirience: {exp} years" +
                $" \nSalary: {okl}$ in nanosek \nTax collection: {sbir}%");
        }
    }
    namespace _3_exercise
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Employee solution\n");

                Employee denchik = new Employee("Lera", " LeraSavchuk");

                denchik.Rozrahunok();

                denchik.Write();

                Console.ReadKey();
            }
        }
    }
}