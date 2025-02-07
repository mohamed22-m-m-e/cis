using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cis
{
    public class General
    {
        int user = 2003;
        int lib = 1200;
        public int User 
        {
            get { return user; }
        }
        public int Lib
        {
            get { return lib; }
        }
        public int login ()
        {
            Console.Write("Please Enter Your PASS Position: ");
            int pass = int.Parse(Console.ReadLine ());
            return pass;
        }
        public void separate ()
        {
            Console.WriteLine("==============================");
        }
    }
    public class User:General
    {
        List<string> bbooks = new List<string> ();
        public void ADD(string x)
        {
            bbooks.Add (x);
            Console.WriteLine($"{x} Book has been borrowed successfully!");
            separate ();
        }
        public string look (string name)
        {
            for (int i = 0; i < bbooks.Count; i++)
            {
                if (name.Equals (bbooks[i]) == true)
                {
                    return bbooks[i];
                }
                else if (i == bbooks.Count - 1)
                {
                    return "NOT FOUND.";
                }
            }
            return "NOT WORKING.";
        }
        public void VIEW ()
        {
            Console.WriteLine("Your BOOKS:");
            for (int i = 0; i < bbooks.Count; i++)
            {
                Console.WriteLine ($"{i + 1}.{bbooks[i]}");
            }
            separate ();
        }
        public void RETURN(string x)
        {
            bbooks.Remove (x);
            Console.WriteLine($"{x} book has been returned successfully!");
            separate ();
        }
    }
    public class Librarin:General
    {
        public List<string> books = new List<string>();
        public Librarin ()
        {
            books.Add ("Point Zero");
            books.Add ("Subs");
        }
        public string look(string name)
        {
            for(int i = 0; i < books.Count; i++)
            {
                if (name.Equals (books[i]) == true)
                {
                    return books[i];
                }
                else if(i == books.Count - 1)
                {
                    return "NOT FOUND.";
                }
            }
            return "NOT WORKING.";
        }
        public void REMOVE(string name)
        {
            books.Remove (name);
            Console.WriteLine ($"{name} book has been deleted successfully!");
            separate ();
        }
        public void ADD(string name)
        {
            books.Add (name);
            Console.WriteLine ($"{name} Book has been added to the library!");
            separate ();
        }
        public void VIEW ()
        {
            Console.WriteLine ("Library`s BOOKS:");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine ($"{i + 1}.{books[i]}");
            }
            separate ();
        }
    }
}
