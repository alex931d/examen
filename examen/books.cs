using System.Collections.Generic;

namespace examen
{
    internal class books
    {
        List<books> book = new List<books>();


        public books(string author, string title, string publisher, int year, int copies, int iSBN, string user)
        {
            Author = author;
            Title = title;
            Publisher = publisher;
            Year = year;
            Copies = copies;
            ISBN = iSBN;
            User = user;
        }

        public string Author { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public int Copies { get; set; }
        public int ISBN { get; set; }
        public string User { get; set; }

        public books()
        {


        }

    /*    public bool isreg()
        {


        } */


    }
}