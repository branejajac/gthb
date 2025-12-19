using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vjezba
{
    public static class admin
    {
        public static void SaveBook(string s)
        {
            StreamWriter sw = new StreamWriter("books.txt", true);
            sw.WriteLine(s);
            sw.Close();
        }
        public static List<string> GetAllAsStrings()
        {
            List<string> books = new List<string>();
            StreamReader sr = new StreamReader("books.txt");
            string s = sr.ReadLine();
            while (s != null)
            {
                s = s.Replace("|", " ");
                books.Add(s);
                s = sr.ReadLine();
            }
            sr.Close();
            return books;
        }
        public static List<string> SearchByTitleOrAuthor(string src)
        {
            List<string> books = new List<string>();
            StreamReader sr = new StreamReader("books.txt");
            string s = sr.ReadLine();
            while (s != null)
            {
                string[] razlomljena = s.Split('|');
                if (razlomljena[1] == src)
                {
                    s=s.Replace("|", " ");
                    books.Add(s);
                    
                }
                if (razlomljena[2] == src)
                {
                    s = s.Replace("|", " ");
                    books.Add(s);
                    
                }
                s = sr.ReadLine();
            }
            sr.Close();
            if(books.Count==0)
            MessageBox.Show("Nema rezultata pretrage");

            return books;
        }
        public static List<int> GetCountByGenre()
        {
            int brr = 0;
            int brd = 0;
            List<int> books = new List<int>();
            StreamReader sr = new StreamReader("books.txt");
            string s = sr.ReadLine();
            while (s != null)
            {
                string[] razlomljena = s.Split('|');
                if (razlomljena[4] == "romantika")
                {
                    brr++;
                }
                else if (razlomljena[4] == "detektivski")
                {
                    brd++;
                }
                s = sr.ReadLine();
            }
            books.Add(brr);
            books.Add(brd);
            sr.Close();
            return books;
        }
    }
}
