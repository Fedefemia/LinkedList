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
            Console.WriteLine
            (
                "8. Testa il metodo AddLast(T).\n" +
                "9. Testa il metodo Clear().\n" +
                "10. Testa il metodo Contains(T).\n" +
                "11. Testa il metodo Find(T).\n" +
                "12. Testa il metodo FindLast(T).\n" +
                "13. Testa il metodo Remove(Node<T>).\n" +
                "14. Testa il metodo Remove(T).\n" +
                "15. Testa il metodo RemoveFirst().\n" +
                "16. Testa il metodo RemoveLast().\n" +
                "17. Testa il metodo ToString().\n"
            );

            string input = Console.ReadLine();
            CLinkedList<int> list = new CLinkedList<int>();
            switch (input)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    Console.WriteLine("\nCaso 1: Provo ad aggiungere un valore a una lista vuota:");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.AddLast(1);
                    Console.WriteLine("Dopo: " + list.ToString());

                    Console.WriteLine("\nCaso 2: Provo ad aggiungere un valore a una lista non vuota:");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.AddLast(2);
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;
                case "9":
                    Console.WriteLine("\nCaso 1: Provo a svuotare una lista gia' vuota:");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.Clear();
                    Console.WriteLine("Dopo: " + list.ToString());

                    Console.WriteLine("\nCaso 2: Provo a svuotare una lista piena:");
                    list.AddLast(1);
                    list.AddLast(2);
                    list.AddLast(3);
                    Console.WriteLine("Prima: " + list.ToString());
                    list.Clear();
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;
                case "10":
                    Console.WriteLine("\nCaso 1: Provo a cercare un valore presente nella lista:");
                    list.AddLast(1);
                    list.AddLast(2);
                    list.AddLast(3);
                    Console.WriteLine("Lista: " + list.ToString());
                    Console.WriteLine("Risultato cercando il numero 3: " + list.Contains(3));
                    list.Clear();

                    Console.WriteLine("\nCaso 2: Provo a cercare un valore mancante dalla lista:");
                    list.AddLast(1);
                    list.AddLast(2);
                    list.AddLast(3);
                    Console.WriteLine("Lista: " + list.ToString());
                    Console.WriteLine("Risultato cercando il numero 4: " + list.Contains(4) + "\n");
                    break;
                case "11":
                    Console.WriteLine("\nCaso 1: Provo a cercare un valore presente nella lista:");
                    list.AddLast(1);
                    list.AddLast(2);
                    list.AddLast(3);
                    Console.WriteLine("Lista: " + list.ToString());
                    Console.WriteLine("Risultato cercando il numero 3: " + list.Find(3).Value + " (questo e' il valore del nodo che la funzione ha trovato)");
                    list.Clear();

                    Console.WriteLine("\nCaso 2: Provo a cercare un valore mancante dalla lista:");
                    list.AddLast(1);
                    list.AddLast(2);
                    list.AddLast(3);
                    Console.WriteLine("Lista: " + list.ToString());
                    Console.WriteLine("Risultato cercando il numero 4: (niente verra' mostrato perche' il risultato e' null)" + list.Find(4) + "\n");
                    break;
                case "12":
                    Console.WriteLine("\nCaso 1: Provo a cercare un valore presente nella lista:");
                    list.AddLast(3);
                    list.AddLast(2);
                    list.AddLast(3);
                    Console.WriteLine("Lista: " + list.ToString());
                    Console.WriteLine("Risultato cercando il numero 3: " + list.FindLast(3).Parent.Value + " (questo e' il valore del parent del nodo che la funzione ha trovato)");
                    list.Clear();

                    Console.WriteLine("\nCaso 2: Provo a cercare un valore mancante dalla lista:");
                    list.AddLast(1);
                    list.AddLast(2);
                    list.AddLast(3);
                    Console.WriteLine("Lista: " + list.ToString());
                    Console.WriteLine("Risultato cercando il numero 4: (niente verra' mostrato perche' il risultato e' null)" + list.Find(4) + "\n");
                    break;
                case "13":
                    Console.WriteLine("\nCaso 1: Provo ad eliminare un nodo trovato con la funzione Find(T):");
                    list.AddLast(1);
                    list.AddLast(2);
                    list.AddLast(3);
                    Console.WriteLine("Prima: " + list.ToString());
                    list.Remove(list.Find(3));
                    Console.WriteLine("Dopo aver rimosso il nodo di valore 3 trovato: " + list.ToString() + "\n");

                    Console.WriteLine("\nCaso 2: Provo ad eliminare un nodo inesistente:");
                    list.AddLast(3);
                    Console.WriteLine("Prima: " + list.ToString());
                    list.Remove(new Node<int>(5));
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;
                case "14":
                    Console.WriteLine("\nCaso 1: Provo ad eliminare un nodo di valore 3:");
                    list.AddLast(1);
                    list.AddLast(2);
                    list.AddLast(3);
                    Console.WriteLine("Prima: " + list.ToString());
                    list.Remove(3);
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");

                    Console.WriteLine("\nCaso 2: Provo ad eliminare un nodo inesistente di valore 4:");
                    list.AddLast(3);
                    Console.WriteLine("Prima: " + list.ToString());
                    list.Remove(4);
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;
                case "15":
                    Console.WriteLine("\nCaso 1: Provo ad eliminare il primo nodo di una lista piena:");
                    list.AddLast(1);
                    list.AddLast(2);
                    list.AddLast(3);
                    Console.WriteLine("Prima: " + list.ToString());
                    list.RemoveFirst();
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");

                    Console.WriteLine("\nCaso 2: Provo ad eliminare il primo nodo di una lista vuota:");
                    list.Clear();
                    Console.WriteLine("Prima: " + list.ToString());
                    list.RemoveFirst();
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;
                case "16":
                    Console.WriteLine("\nCaso 1: Provo ad eliminare l'ultimo nodo di una lista piena:");
                    list.AddLast(1);
                    list.AddLast(2);
                    list.AddLast(3);
                    Console.WriteLine("Prima: " + list.ToString());
                    list.RemoveLast();
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");

                    Console.WriteLine("\nCaso 2: Provo ad eliminare l'ultimo nodo di una lista vuota:");
                    list.Clear();
                    Console.WriteLine("Prima: " + list.ToString());
                    list.RemoveLast();
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;
                case "17":
                    Console.WriteLine("\nCaso 1: Provo a stampare una lista piena:");
                    list.AddLast(1);
                    list.AddLast(2);
                    list.AddLast(3);
                    Console.WriteLine("Lista: " + list.ToString() + "\n");

                    Console.WriteLine("\nCaso 2: Provo a stampare una lista vuota:");
                    list.Clear();
                    Console.WriteLine("Lista: " + list.ToString() + "\n");
                    break;
                default:
                    Console.WriteLine("\nInput invalido.\n");
                    break;
            }
            Menu();
        }
    }
}