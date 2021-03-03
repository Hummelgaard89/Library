using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {

        static void Main(string[] args)
        {
            //Creating a list of all the books in the library
            List<Books> librarybooks = new List<Books>();
            librarybooks.Add(new Books(1, "To Kill A Mockingbird", "Harper", "Lee", 1960, 281));
            librarybooks.Add(new Books(2, "Great Expectations", "Charles", "Dickens", 1861, 544));
            librarybooks.Add(new Books(3, "Lolita", "Vladimir", "Nabokov", 1955, 441));
            librarybooks.Add(new Books(4, "Lord of the Flies", "William", "Golding", 1954, 224));
            librarybooks.Add(new Books(5, "The Scarlet Letter by", "Nathaniel", "Hawthorne", 1850, 237));
            //Creating a list of the books available to borrow
            List<Books> availablebooks = new List<Books>();
            availablebooks = librarybooks;
            //Creating a stack of the books borrowed
            Stack<Books> borrowed = new Stack<Books>();

            PrintAvailableBooks(availablebooks);
            
            string textinput = "";
            string oldtext = "";
            MainMenu();
            do
            {
                textinput = Getstring("");
                if (textinput == "1")
                {
                    //Tells the user to input the id of the book and converts it to int to compare with bookid
                    Console.WriteLine("Type in the book id of the book you want to borrow");
                    string userinput = Console.ReadLine();
                    int bookidinput = Convert.ToInt32(userinput);
                    //Runs trough the list availablebooks and compares with the userinput
                    for (int i = 0; i < availablebooks.Count; i++)
                    {
                        //If the userinput matches an available book.
                        if (availablebooks[i].Bookid == bookidinput)
                        {
                            //Makes a new book to manipulate with.
                            Books booktoborrow = new Books(availablebooks[i].Bookid,
                                                           availablebooks[i].Booktitle,
                                                           availablebooks[i].Authorfirstname,
                                                           availablebooks[i].Authorlastname,
                                                           availablebooks[i].Releaseyear,
                                                           availablebooks[i].Pages);
                            //Removes the book from the available list and "adds" the new book to the stack of borrowed books
                            availablebooks.RemoveAt(i);
                            borrowed.Push(booktoborrow);
                        }
                    }
                    Console.Clear();
                    PrintAvailableBooks(availablebooks);
                    MainMenu();
                }//End Textinput ==1
                else if (textinput == "2")
                {
                    PrintBorrowedBooks(borrowed);
                    MainMenu();
                    
                }//End Textinput ==2
                else if (textinput == "3")
                {
                    for (int i = 0; i < borrowed.Count; i++)
                    {
                        //Finalises the borrowing of the book by also removing it from the borrowed checkout list.
                        borrowed.Peek();
                        borrowed.Pop();
                    }
                    PrintAvailableBooks(availablebooks);
                    MainMenu();
                }//End Textinput ==3
                textinput = oldtext;
            } while (textinput.ToLower() != "exit");


        }//End Main
        static void MainMenu()
            //Prints out the main menu.
        {
            Console.WriteLine("Do you want to borrow a(nother) book?\nType 1.\n");
            Console.WriteLine("To see the books you have in your checkout list.\nType 2");
            Console.WriteLine("Check out books.\nType 3");
            Console.WriteLine("\n \nType \"exit\" to exit.");
        }//End MainMenu
        
        public static void PrintAvailableBooks (List<Books>availablebooks)
            //Method that prinst out the list of available books in green, to make it easy to see the difference.
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("AVAILABLE BOOKS:\n\n");
            //Prinsts out all availeble books
            foreach (Books booknumber in availablebooks)
            {
                
                Console.WriteLine("Bookid: " + booknumber.Bookid);
                Console.WriteLine("Book title: " + booknumber.Booktitle);
                Console.WriteLine("Author: " + booknumber.Authorfirstname + " " + booknumber.Authorlastname);
                Console.WriteLine("Release year: " + booknumber.Releaseyear);
                Console.WriteLine("Pages: " + booknumber.Pages + "\n");
            }
            //Sets color of the text back to white for the menu.
            Console.ForegroundColor = ConsoleColor.White;
        }//End PrintAvailableBooks
        public static void PrintBorrowedBooks(Stack<Books> borrowed)
        //Method that prinst out the list of borrowed books in red, to make it easy to see the difference.

        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("BORROWED BOOKS:\n\n");
            //Prinsts out all borrowed books
            foreach (Books booknumber in borrowed)
            {
                
                Console.WriteLine("Bookid: " + booknumber.Bookid);
                Console.WriteLine("Book title: " + booknumber.Booktitle);
                Console.WriteLine("Author: " + booknumber.Authorfirstname + " " + booknumber.Authorlastname);
                Console.WriteLine("Release year: " + booknumber.Releaseyear);
                Console.WriteLine("Pages: " + booknumber.Pages + "\n");
            }
            //Sets color of the text back to white for the menu.
            Console.ForegroundColor = ConsoleColor.White;
        }//End PrintBorrowedBooks
        static string Getstring(String prompt)
        {
            Console.Write(prompt + "");
            return Console.ReadLine();
        }//End Getstring
    }
}
