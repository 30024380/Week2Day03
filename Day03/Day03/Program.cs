using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Please Enter A Number 1 | 2 | 3");
            int t1 = int.Parse(Console.ReadLine());
           
            if (t1 == 1)
            {
                Console.WriteLine("Please Enter Your First Name");
                string fname = Console.ReadLine();

                Console.WriteLine("Please Enter Your Last Name");
                var lname = Console.ReadLine();

                Console.WriteLine("Please Enter Your Age");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter Your Gender");
                var gender = Console.ReadLine();

                Console.WriteLine("Please Enter Your Address");
                string address = Console.ReadLine();

                Console.WriteLine("Hello " + fname + " " + lname);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Gender: " + gender);
                Console.WriteLine("Address: " + address);

                Console.ReadLine();
            }
            if (t1 == 2)
            {

                Console.WriteLine("Please Enter A Number");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter Another Number");
                double num2 = double.Parse(Console.ReadLine());

                Double answer;

                //Converts numbers according to the equation
                answer = num1 + num2;
                Console.WriteLine("{0} + {1} = {2}", num1, num2, answer);
                answer = num1 - num2;
                Console.WriteLine("{0} - {1} = {2}", num1, num2, answer);
                answer = num1 * num2;
                Console.WriteLine("{0} * {1} = {2}", num1, num2, answer);
                answer = num1 / num2;
                Console.WriteLine("{0} / {1} = {2}", num1, num2, answer);

                Console.ReadLine();
            }
            if (t1 == 3)
            {
                var i = 10;
                Console.WriteLine("i = " + i);

                i++;
                Console.WriteLine("i = " + i);
                i++;
                Console.WriteLine("i = " + i);
                i++;
                Console.WriteLine("i = " + i);

                Console.ReadLine();
            }
               
        }
    }
}
