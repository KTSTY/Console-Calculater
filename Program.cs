using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculater
{
    class Program
    {
        static void Main(string[] args)
        {
            nonstart();
            Console.ReadLine();
        }
        private static void nonstart()
        {
            startmain();
            Console.ReadLine();
        }

        private static void startmain()
        {
            Console.WriteLine("Welcome In First Console Calculater By PharCode :)");
            //Console.WriteLine("This App Was Developed By KTSTY");
            Console.WriteLine("Please Choose The Desired Account operation And Press Enter");
            Console.WriteLine("for + Select 1");
            Console.WriteLine("for - Select 2");
            Console.WriteLine("for X Select 3");
            Console.WriteLine("for ÷ Select 4");
            int acc = int.Parse(Console.ReadLine());

            if (acc == 1)
            {
                plusword();
            }
            else if (acc == 2)
            {
                lowword();
            }
            else if (acc == 3)
            {
                highword();
            }
            else if (acc == 4)
            {
                medword();
            }
            else
            {
                nonstart();
            }

        }
        private static void plusword()
        {

            Console.WriteLine("enter your first no: ");
            float first = float.Parse(Console.ReadLine());
            Console.WriteLine("enter your second no: ");
            float second = float.Parse(Console.ReadLine());
            float Anser = first + second;
            Console.WriteLine("The Answer Is " + Anser);
            Console.WriteLine("Another Operation Yes Or No And Press Triple Enter");
            Console.WriteLine("for Yes Select 1");
            Console.WriteLine("for No Select 2");
            float yn = float.Parse(Console.ReadLine());
            if (yn == 1)

            {
                startmain();
            }
        }
        private static void lowword()
        {

            Console.WriteLine("enter your first no: ");
            float first = float.Parse(Console.ReadLine());
            Console.WriteLine("enter your second no: ");
            float second = float.Parse(Console.ReadLine());
            float Anser = first - second;
            Console.WriteLine("The Answer Is " + Anser);
            Console.WriteLine("Another Operation Yes Or No And Press Triple Enter");
            Console.WriteLine("for Yes Select 1");
            Console.WriteLine("for No Select 2");

            float yn = float.Parse(Console.ReadLine());
            if (yn == 1)

            {
                startmain();
            }
        }

        private static void highword()
        {

            Console.WriteLine("enter your first no: ");
            float first = float.Parse(Console.ReadLine());
            Console.WriteLine("enter your second no: ");
            float second = float.Parse(Console.ReadLine());
            float Anser = first * second;
            Console.WriteLine("The Answer Is " + Anser);
            Console.WriteLine("Another Operation Yes Or No And Press Triple Enter");
            Console.WriteLine("for Yes Select 1");
            Console.WriteLine("for No Select 2");
            float yn = float.Parse(Console.ReadLine());
            if (yn == 1)

            {
                startmain();
            }
        }
        private static void medword()
        {

            Console.WriteLine("enter your first no: ");
            float first = float.Parse(Console.ReadLine());
            Console.WriteLine("enter your second no: ");
            float second = float.Parse(Console.ReadLine());
            float Anser = first / second;
            Console.WriteLine("The Answer Is " + Anser);
            Console.WriteLine("Another Operation Yes Or No And Press Triple Enter");
            Console.WriteLine("for Yes Select 1");
            Console.WriteLine("for No Select 2");
            float yn = float.Parse(Console.ReadLine());
            if (yn == 1)

            {
                startmain();
            }
            
        }
        void lastword()
        {
            Console.ReadLine();
        }
       
    }

}




