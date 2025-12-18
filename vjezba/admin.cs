using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            List<string> results = new List<string>();
            StreamReader sr = new StreamReader("books.txt");
            string s = sr.ReadLine();
            while (s != null)
            {
                string[] razlomljena = s.Split('|');
                if (razlomljena[1] == src)
                {
                    results.Add(s);
                    s = sr.ReadLine();
                }
                else if (razlomljena[2] == src)
                {
                    results.Add(s);
                    s = sr.ReadLine();
                }
            }
            sr.Close();
            return results;
        }
        public static List<int> GetCountByGenre()
        {
            int brRomantika = 0;
            int brDetektivski = 0;
            List<int> counts = new List<int>();
            StreamReader sr = new StreamReader("books.txt");
            string s = sr.ReadLine();
            while (s != null)
            {
                string[] razlomljena = s.Split('|');
                if (razlomljena[4] == "Romantika")
                {
                    brRomantika++;
                }
                else if (razlomljena[4] == "Detektivski")
                {
                    brDetektivski++;
                }
                s = sr.ReadLine();
            }
            counts.Add(brRomantika);
            counts.Add(brDetektivski);
            sr.Close();
            return counts;
        }
    }
}
