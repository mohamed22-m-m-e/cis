using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cis
{
    public class Program
    {
        static void Main (string[] args)
        {
            General general = new General();
            User user = new User ();
            Librarin librarin = new Librarin ();
            label:
            int pass = general.login ();
            if (pass == general.User)
            {
                Console.WriteLine("Welcome to your Library!!");
                for(int i = 0; i < 1;) 
                { 
                    Console.WriteLine("1.Borrow a book.\n2.Return a book.\n3.View my books.\n4.EXIT.\n5.Shut down.");
                    Console.Write("Tell US How can We Help You: ");
                    int num = int.Parse(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            Console.Write("Enter the name of the book you want: ");
                            string title = Console.ReadLine();
                            if (librarin.look (title).Equals ("NOT FOUND.") == true)
                            {
                                Console.WriteLine("NOT FOUND.");
                                general.separate ();
                                break;
                            }
                            else
                            {
                                user.ADD (title);
                                librarin.books.Remove (title);
                                break; 
                            }
                        case 2:
                            Console.Write ("Enter the name of the book you want: ");
                            string name = Console.ReadLine();
                            if (user.look (name).Equals ("NOT FOUND.") == true)
                            {
                                Console.WriteLine ($"{name} book is not exist.");
                                general.separate ();
                                break;
                            }
                            else
                            {
                                user.RETURN (name);
                                librarin.books.Add (name);
                                break;
                            }
                        case 3:
                            user.VIEW ();
                            break;
                        case 4:
                            Console.WriteLine ("EXITING...");
                            goto label;
                        case 5:
                            Console.WriteLine ("Shutting down...");
                            return;
                    }
                }
            }
            else if (pass == general.Lib)
            {
                Console.WriteLine ("Welcome to your Library!!");
                for (int i = 0; i < 1;)
                {
                    Console.WriteLine ("1.Add a book.\n2.Rmove a book.\n3.View my books.\n4.EXIT.\n5.Shut down.");
                    Console.Write ("Tell US How can We Help You: ");
                    int num = int.Parse (Console.ReadLine ());
                    switch (num)
                    {
                        case 1:
                            Console.Write ("Enter the name of the book you want: ");
                            string title = Console.ReadLine ();
                            if (librarin.look (title).Equals ("NOT FOUND.") == false)
                            {
                                Console.WriteLine ("Already Exists.");
                                general.separate ();
                                break;
                            }
                            else
                            {
                                librarin.ADD (title);
                                break;
                            }
                        case 2:
                            Console.Write ("Enter the name of the book you want: ");
                            string name = Console.ReadLine ();
                            if (librarin.look (name).Equals ("NOT FOUND.") == true)
                            {
                                Console.WriteLine ("The book you want to delete is not found.");
                                general.separate ();
                                break;
                            }
                            else
                            {
                                librarin.REMOVE (name);
                                break;
                            }
                        case 3:
                            librarin.VIEW ();
                            break;
                        case 4:
                            Console.WriteLine ("EXITING...");
                            goto label;
                        case 5:
                            Console.WriteLine("Shutting down...");
                            return;
                    }
                }
            }
            else
            {
                Console.WriteLine ("INVALID COMMAND!");
                general.separate ();
            }
        }
    }
}
