using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    //Class for books with relevant properties for books
    public class Books
    {
        //Variables for books.
        private int bookid;
        private string booktitle;
        private string authorfirstname;
        private string authorlastname;
        private int releaseyear;
        private int pages;

        //Constructor for making a book.
        public Books(int _bookid, string _booktitle, string _authorfirstname, string _authorlastname, int _releaseyear, int _pages)
        {
            bookid = _bookid;
            booktitle = _booktitle;
            authorfirstname = _authorfirstname;
            authorlastname = _authorlastname;
            releaseyear = _releaseyear;
            pages = _pages;
        }

        //Set and get
        public int Bookid 
        {
            get { return bookid; }
            set { bookid = value; }
        }
        public string Booktitle
        {
            get { return booktitle; }
            set { booktitle = value; }
        }
        public string Authorfirstname
        {
            get { return authorfirstname; }
            set { authorfirstname = value; }
        }
        public string Authorlastname
        {
            get { return authorlastname; }
            set { authorlastname = value; }
        }
        public int Releaseyear
        {
            get { return releaseyear; }
            set { releaseyear = value; }
        }
        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }
    }
}
