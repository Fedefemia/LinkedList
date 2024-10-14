using System;
using System.Threading;
using System.Xml.Linq;

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
            Console.WriteLine("Seleziona un'operazione:");
            Console.WriteLine("1.  Aggiungere un valore dopo un nodo.");
            Console.WriteLine("2.  Aggiungere un nodo prima di un nodo.");
            Console.WriteLine("3.  Aggiungere un nodo all'inizio della lista.");
            Console.WriteLine("4.  Aggiungere un valore all'inizio della lista.");
            Console.WriteLine("5.  Aggiungere un nodo alla fine della lista.");
            Console.WriteLine("6.  Aggiungere un valore alla fine della lista.");
            Console.WriteLine("7.  Svuotare una lista.");
            Console.WriteLine("8.  Aggiungere un valore a una lista vuota.");
            Console.WriteLine("9.  Svuotare una lista già vuota.");
            Console.WriteLine("10. Cercare un valore presente nella lista.");
            Console.WriteLine("11. Trovare un valore nella lista.");
            Console.WriteLine("12. Trovare l'ultimo valore nella lista.");
            Console.WriteLine("13. Eliminare un nodo trovato con Find.");
            Console.WriteLine("14. Eliminare un nodo di un valore specifico.");
            Console.WriteLine("15. Eliminare il primo nodo.");
            Console.WriteLine("16. Eliminare l'ultimo nodo.");
            Console.WriteLine("17. Stampare la lista.");
            Console.WriteLine("18. Testa tutto.\n");

            string input = Console.ReadLine();
            CLinkedList<int> list = new CLinkedList<int>();
            CLinkedList<int> listv = new CLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            switch (input)
            {
                case "1":
                    Console.WriteLine("\nCaso 1: Provo ad aggiungere un valore al nodo contenente 2 (tramite funzione Find) di una lista vuota:");
                    Console.WriteLine("Prima: " + listv.ToString());
                    listv.AddAfter(new Node<int>(1), new Node<int>(12));
                    Console.WriteLine("Dopo: " + listv.ToString());

                    Console.WriteLine("\nCaso 2: Provo ad aggiungere un valore al nodo contenente 2 (tramite funzione Find) di una lista non vuota:");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.AddAfter(list.Find(2), new Node<int>(12));
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;
                case "2":
                    Console.WriteLine("\nCaso 1: Provo ad aggiungere un nodo prima del nodo contenente 2 (tramite Find) in una lista vuota:");
                    Console.WriteLine("Prima: " + listv.ToString());
                    listv.AddBefore(new Node<int>(1), 12);
                    Console.WriteLine("Dopo: " + listv.ToString());

                    Console.WriteLine("\nCaso 2: Provo ad aggiungere un nodo prima del nodo contenente 2 in una lista non vuota:");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.AddBefore(list.Find(2), 12);
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;

                case "3":
                    Console.WriteLine("\nCaso 1: Provo ad aggiungere un nodo all'inizio di una lista vuota:");
                    Console.WriteLine("Prima: " + listv.ToString());
                    listv.AddFirst(new Node<int>(10));
                    Console.WriteLine("Dopo: " + listv.ToString());

                    Console.WriteLine("\nCaso 2: Provo ad aggiungere un nodo all'inizio di una lista non vuota:");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.AddFirst(new Node<int>(0));
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;

                case "4":
                    Console.WriteLine("\nCaso 1: Provo ad aggiungere un valore all'inizio di una lista vuota:");
                    Console.WriteLine("Prima: " + listv.ToString());
                    listv.AddFirst(10);
                    Console.WriteLine("Dopo: " + listv.ToString());

                    Console.WriteLine("\nCaso 2: Provo ad aggiungere un valore all'inizio di una lista non vuota:");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.AddFirst(0);
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;

                case "5":
                    Console.WriteLine("\nCaso 1: Provo ad aggiungere un nodo alla fine di una lista vuota:");
                    Console.WriteLine("Prima: " + listv.ToString());
                    listv.AddLast(new Node<int>(1));
                    Console.WriteLine("Dopo: " + listv.ToString());

                    Console.WriteLine("\nCaso 2: Provo ad aggiungere un nodo alla fine di una lista non vuota:");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.AddLast(new Node<int>(4));
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;

                case "6":
                    Console.WriteLine("\nCaso 1: Provo ad aggiungere un valore alla fine di una lista vuota:");
                    Console.WriteLine("Prima: " + listv.ToString());
                    listv.AddLast(1);
                    Console.WriteLine("Dopo: " + listv.ToString());

                    Console.WriteLine("\nCaso 2: Provo ad aggiungere un valore alla fine di una lista non vuota:");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.AddLast(4);
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;

                case "7":
                    Console.WriteLine("\nCaso 1: Provo a svuotare una lista già vuota:");
                    Console.WriteLine("Prima: " + listv.ToString());
                    listv.Clear();
                    Console.WriteLine("Dopo: " + listv.ToString());

                    Console.WriteLine("\nCaso 2: Provo a svuotare una lista piena:");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.Clear();
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;
                case "8":
                    Console.WriteLine("\nCaso 1: Provo ad aggiungere un valore a una lista vuota:");
                    Console.WriteLine("Prima: " + listv.ToString());
                    listv.AddLast(1);
                    Console.WriteLine("Dopo: " + listv.ToString());

                    Console.WriteLine("\nCaso 2: Provo ad aggiungere un valore a una lista non vuota:");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.AddLast(2);
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;
                case "9":
                    Console.WriteLine("\nCaso 1: Provo a svuotare una lista gia' vuota:");
                    Console.WriteLine("Prima: " + listv.ToString());
                    listv.Clear();
                    Console.WriteLine("Dopo: " + listv.ToString());

                    Console.WriteLine("\nCaso 2: Provo a svuotare una lista piena:");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.Clear();
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;
                case "10":
                    Console.WriteLine("\nCaso 1: Provo a cercare un valore presente nella lista:");
                    Console.WriteLine("Lista: " + list.ToString());
                    Console.WriteLine("Risultato cercando il numero 3: " + list.Contains(3));
                    list.Clear();

                    Console.WriteLine("\nCaso 2: Provo a cercare un valore mancante dalla lista:");
                    Console.WriteLine("Lista: " + list.ToString());
                    Console.WriteLine("Risultato cercando il numero 4: " + list.Contains(4) + "\n");
                    break;
                case "11":
                    Console.WriteLine("\nCaso 1: Provo a cercare un valore presente nella lista:");
                    Console.WriteLine("Lista: " + list.ToString());
                    Console.WriteLine("Risultato cercando il numero 3: " + list.Find(3).Value + " (questo e' il valore del nodo che la funzione ha trovato)");
                    list.Clear();

                    Console.WriteLine("\nCaso 2: Provo a cercare un valore mancante dalla lista:");
                    Console.WriteLine("Lista: " + list.ToString());
                    Console.WriteLine("Risultato cercando il numero 4: (niente verra' mostrato perche' il risultato e' null)" + list.Find(4) + "\n");
                    break;
                case "12":
                    Console.WriteLine("\nCaso 1: Provo a cercare un valore presente nella lista:");
                    Console.WriteLine("Lista: " + list.ToString());
                    Console.WriteLine("Risultato cercando il numero 3: " + list.FindLast(3).Parent.Value + " (questo e' il valore del parent del nodo che la funzione ha trovato)");
                    list.Clear();

                    Console.WriteLine("\nCaso 2: Provo a cercare un valore mancante dalla lista:");
                    Console.WriteLine("Lista: " + list.ToString());
                    Console.WriteLine("Risultato cercando il numero 4: (niente verra' mostrato perche' il risultato e' null)" + list.Find(4) + "\n");
                    break;
                case "13":
                    Console.WriteLine("\nCaso 1: Provo ad eliminare un nodo trovato con la funzione Find(T):");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.Remove(list.Find(3));
                    Console.WriteLine("Dopo aver rimosso il nodo di valore 3 trovato: " + list.ToString() + "\n");

                    Console.WriteLine("\nCaso 2: Provo ad eliminare un nodo inesistente (12):");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.Remove(new Node<int>(12));
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;
                case "14":
                    Console.WriteLine("\nCaso 1: Provo ad eliminare un nodo di valore 3:");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.Remove(3);
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");

                    Console.WriteLine("\nCaso 2: Provo ad eliminare un nodo inesistente di valore 4:");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.Remove(4);
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");
                    break;
                case "15":
                    Console.WriteLine("\nCaso 1: Provo ad eliminare il primo nodo di una lista piena:");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.RemoveFirst();
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");

                    Console.WriteLine("\nCaso 2: Provo ad eliminare il primo nodo di una lista vuota:");
                    Console.WriteLine("Prima: " + listv.ToString());
                    listv.RemoveFirst();
                    Console.WriteLine("Dopo: " + listv.ToString() + "\n");
                    break;
                case "16":
                    Console.WriteLine("\nCaso 1: Provo ad eliminare l'ultimo nodo di una lista piena:");
                    Console.WriteLine("Prima: " + list.ToString());
                    list.RemoveLast();
                    Console.WriteLine("Dopo: " + list.ToString() + "\n");

                    Console.WriteLine("\nCaso 2: Provo ad eliminare l'ultimo nodo di una lista vuota:");
                    Console.WriteLine("Prima: " + list.ToString());
                    listv.RemoveLast();
                    Console.WriteLine("Dopo: " + listv.ToString() + "\n");
                    break;
                case "17":
                    Console.WriteLine("\nCaso 1: Provo a stampare una lista piena:");
                    Console.WriteLine("Lista: " + list.ToString() + "\n");

                    Console.WriteLine("\nCaso 2: Provo a stampare una lista vuota:");
                    Console.WriteLine("Lista: " + listv.ToString() + "\n");
                    break;
                case "18":
                    Console.WriteLine("Eseguendo test completo...");
                    list.AddFirst(1);
                    list.AddLast(2);
                    list.AddLast(3);
                    Console.WriteLine("Lista dopo aggiunta: " + list.ToString());
                    Console.WriteLine("Ricerca di un valore (2): " + list.Find(2)?.Value);
                    Console.WriteLine("Ricerca di un valore (4): " + list.Find(4));
                    list.AddAfter(list.Find(2), 4);
                    list.AddBefore(list.Find(2), 5);
                    Console.WriteLine("Lista dopo aggiunta in posizioni specifiche: " + list.ToString());
                    list.Remove(3);
                    Console.WriteLine("Lista dopo rimozione di 3: " + list.ToString());
                    list.RemoveFirst();
                    Console.WriteLine("Lista dopo rimozione del primo nodo: " + list.ToString());
                    list.RemoveLast();
                    Console.WriteLine("Lista dopo rimozione dell'ultimo nodo: " + list.ToString());
                    list.Clear();
                    Console.WriteLine("Lista dopo svuotamento: " + list.ToString());
                    list.AddLast(10);
                    Console.WriteLine("Lista dopo aggiunta a lista vuota: " + list.ToString());
                    list.Clear();
                    Console.WriteLine("Lista vuota per test di eliminazione: " + list.ToString());
                    list.RemoveFirst();
                    list.RemoveLast();
                    Console.WriteLine("Lista dopo tentativo di eliminazione da lista vuota: " + list.ToString());
                    Console.WriteLine("Test completato.\n");
                    Console.Write("Continua");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(100);
                        Console.Write(".");
                    }
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("\nInput invalido.\n");
                    break;
            }
            Menu();
        }
    }
}