using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminProject.Controllers
{
    public class Program
    {
        static string _fristname;// non static membar
        static string _lastname;//non static membar

        public static void PrintFullName() //non static membar
        {
            Console.WriteLine("FullName=" + _fristname + _lastname);
            int i = 100;
            Console.WriteLine(i);
        }
        public static void Main() //static membar
        {

            Program._fristname = "kerrti";
            Program._lastname = "Singh";
            Program.PrintFullName();

            Console.ReadLine();

        }
    }
}