using static System.Formats.Asn1.AsnWriter;

namespace dz5
{
    internal class Program
    {
        static void Main()
        {
            int ch;
            do
            {
                Console.Write("Enter number of task 1 - 3: ");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Magazine magazine1 = new Magazine();
                        Magazine magazine2 = new Magazine();
                        magazine1.Input();
                        Console.WriteLine();
                        magazine2.Input();
                        Console.WriteLine("\nShow info:");
                        magazine1.Show();
                        Console.WriteLine();
                        magazine2.Show();
                        Console.WriteLine();
                        magazine1 += 100;
                        magazine2 += 100;
                        Console.Write("\nWorkers of magazine 1: ");
                        magazine1.ShowWorkers();
                        Console.Write("\nWorkers of magazine 2: ");
                        magazine2.ShowWorkers();

                        if (magazine1 == magazine2)
                        {
                            Console.WriteLine("\nMagazines have equal workers.");
                        }

                        if (magazine1 > magazine2)
                        {
                            Console.WriteLine("\nMagazines 1 has higher workers than Magazines 2.");
                        }

                        else if (magazine1 < magazine2)
                        {
                            Console.WriteLine("\nMagazines 2 has higher workers than Magazines 1.");
                        }

                        if (magazine1 != magazine2)
                        {
                            Console.WriteLine("\nMagazines have different workers.");
                        }

                        if (magazine1.Equals(magazine2))
                        {
                            Console.WriteLine("\nMagazines are the equal.");
                        }
                        break;
                    case 2:
                        Store store1 = new Store();
                        Store store2 = new Store();
                        store1.Input();
                        Console.WriteLine();
                        store2.Input();
                        Console.WriteLine("\nShow info:");
                        store1.Show();
                        Console.WriteLine();
                        store2.Show();
                        Console.WriteLine();
                        store1 += 1200.25;
                        store2 += 750.3;
                        Console.Write("\nSquare of store one: ");
                        store1.ShowSquare();
                        Console.Write("\nSquare of store two: ");
                        store2.ShowSquare();

                        if (store1 == store2)
                        {
                            Console.WriteLine("\nStores have equal square.");
                        }



                        else if (store1 < store2)
                        {
                            Console.WriteLine("\nStore two has higher square than Store one.");
                        }
                        if (store1 > store2)
                        {
                            Console.WriteLine("\nStore one  has higher square than Store two.");
                        }

                        if (store1 != store2)
                        {
                            Console.WriteLine("\nStores have different square.");
                        }

                        if (store1.Equals(store2))
                        {
                            Console.WriteLine("\nStores are the equal.");
                        }
                        break;
                    case 3:
                        Book book = new Book();
                        do
                        {
                            Console.WriteLine("Menu:\n1 - Add book\n2 - Remove book\n3 - Check book in list\n4 - Show the number of book in list\n5 - Show a list of book\n0 - Exit");
                            Console.Write("Your choice: ");
                            ch = int.Parse(Console.ReadLine());

                            switch (ch)
                            {
                                case 1:
                                    Console.Write("\nEnter name of book: ");
                                    string add = Console.ReadLine();
                                    book.Add(add);
                                    Console.WriteLine("Book '" + add + "' add .");
                                    break;
                                case 2:
                                    Console.Write("\nEnter name of book: ");
                                    string remove = Console.ReadLine();
                                    book.Remove(remove);
                                    Console.WriteLine("Book '" + remove + "' remove.");
                                    break;
                                case 3:
                                    Console.Write("\nEnter name of book: ");
                                    string find = Console.ReadLine();
                                    if (book.Contains(find))
                                    {
                                        Console.WriteLine("Book '" + find + "' available");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Book '" + find + "' doesn`t exist .");
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("\nNumber of book : " + book.Count);
                                    break;
                                case 5:
                                    Console.WriteLine("\nList of book:");
                                    for (int i = 0; i < book.Count; i++)
                                    {
                                        Console.WriteLine((i + 1) + " - " + book[i]);
                                    }
                                    break;
                                case 0:
                                    Console.WriteLine("\nExit!");
                                    break;
                                default:
                                    Console.WriteLine("\nError");
                                    break;
                            }
                            Console.WriteLine();
                        } while (ch != 0);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            } while (ch < 1 || ch > 3);
        }
    }
}