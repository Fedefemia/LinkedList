using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedArrayTiba
{
    internal class Program
    {
        public static CLinkedList<string> lista = new CLinkedList<string>();
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            //Console.Clear();
            //Console.WriteLine("1 Add\n2 Print");
            //string num = Console.ReadLine();
            //int numf;
            //while (!int.TryParse(num, out numf) && numf != 1 && numf != 2)
            //{
            //    Console.WriteLine("Riprova");
            //    num = Console.ReadLine();
            //}
            //if (numf == 1)
            //{
            //    Console.WriteLine("Aggiungi");
            //    string par = Console.ReadLine();
            //    lista.Add(par);
            //}
            //else
            //{
            //    lista.Print();
            //}
            //Console.ReadKey();
            //Menu();

            CLinkedList<int> lista = new CLinkedList<int>();
            lista.Add(5);
            lista.Clear();
            lista.Add(12);
            Console.WriteLine(lista.ToString());
            Console.ReadKey();
        }
    }
}