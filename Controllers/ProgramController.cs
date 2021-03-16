using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminProject.Controllers
{
    public class ProgramController : Controller
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

            ProgramController._fristname = "kerrti";
            ProgramController._lastname = "Singh";
            ProgramController.PrintFullName();

            Console.ReadLine();

        }
    }
}