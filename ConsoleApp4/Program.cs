using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNotebook;

namespace MyProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.Model = "Модель ноутбука";
            notebook.Year = 2023;
            notebook.on();

            Console.ReadLine();

        }
    }
}