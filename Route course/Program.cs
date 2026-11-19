using System.Globalization;
using System.Linq.Expressions;
using System.Text;

namespace Route_course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            ////1-Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change. 
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion

            #region Question02
            ////2-Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory. 
            //string title1 = "clean code";
            //string title2 = "clean code";
            //bool isSameReferences = object.ReferenceEquals(title1, title2);
            //Console.WriteLine(isSameReferences);
            #endregion

            #region Question03
            //3-Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object. Print the final result. 
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - updated");
            ////Console.WriteLine(sb);
            #endregion

            #region Question04
            ////4-Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result. 
            //sb.Replace("Book List" , "Library");
            //Console.WriteLine(sb);
            #endregion

            #region Question05
            ////5-Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator. 
            //string title = "Clean Code";
            //int pages = 464;
            ////string sentence = "Book: " + title + ", pages:" + pages;
            ////Console.WriteLine(sentence);
            #endregion

            #region Question06
            //6-Build the same sentence as above, but using string interpolation ($"..."). 
            //string sentence = $"Book: {title}, pages: {pages}";
            //Console.WriteLine(sentence);
            #endregion

            #region Question07
            ////7-Build the same sentence again, but using string.Format().
            //string sentence = string.Format("Book: {0}, pages:{1}", title, pages);
            //Console.WriteLine(sentence);
            #endregion

            #region Queation08
            ////8-Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book". 
            //int pages = 464;
            //if (pages>300)
            //{
            //    Console.WriteLine("long book");
            //}
            //else
            //    Console.WriteLine("short book");
            #endregion

            #region Question09
            ////9-Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true. Use the && operator. 
            //int pages = 464;
            //bool isAvailable = true;
            //if (pages>300 && isAvailable)
            //{
            //    Console.WriteLine("you can borrow this book");
            //}
            #endregion

            #region Question10
            ////10-Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else. 
            //string title = "Refactoring";

            //switch (title)
            //{
            //    case "clean code":
            //        Console.WriteLine("great choise!");
            //        break;

            //    case "Refactoring":
            //        Console.WriteLine("nice pick");
            //        break;
            //    default:
            //        Console.WriteLine("never heard of it");
            //        break;
            //}
            #endregion

            #region Question11
            ////11-Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel (same rule as question 8: long if pages > 300). 
            //int pages = 464;
            //string sizeLabel = (pages > 300) ? "long book" : "short book";
            //Console.WriteLine(sizeLabel);
            #endregion

            #region Question12
            ////12-Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1. Clean Code. 
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}. {books[i]}");
            //}
            #endregion

            #region Question13
            ////13-Using the same books array, use a while loop to print every book title.
            //int i = 0;
            //while (i < books.Length)
            //{
            //    Console.WriteLine(books[i]);
            //    i++;
            //}
            #endregion

            #region Question14
            //14-Write a do-while loop that prints "Checking book..." exactly 3 times. 
            //int count = 0;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    count++;
            //}
            //while (count<3);
            #endregion

            #region Question15
            ////15-Using the same books array, use a foreach loop to print every book title. 
            string[] books = { "clean code", "the pragmatic programmer", "refactoring" };
            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}
            #endregion

            #region Question16
            ////16-Using the same books array, loop through it and print each title, but stop completely (break) once you reach "Refactoring". 
            //foreach (string book in books)
            //{
            //    if (book == "refactoring")
            //    {
            //        break;
            //    }
            //    Console.WriteLine(book);
            //}
            #endregion

            #region Queation17
            //17-Using the same books array, print every title except "The Pragmatic Programmer" (skip it with continue, don't stop the loop). 
            foreach (string book in books)
            {
                if (book == "the pragmatic programmer")
                {
                    continue;
                }
                Console.WriteLine(book);
            }
            
            #endregion
        }
    }
}
     
