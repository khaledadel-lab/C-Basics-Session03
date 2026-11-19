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
            //5-Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator. 
            string title = "Clean Code";
            int pages = 464;
            //string sentence = "Book: " + title + ", pages:" + pages;
            //Console.WriteLine(sentence);
            #endregion

            #region Question06
            //6-Build the same sentence as above, but using string interpolation ($"..."). 
            string sentence = $"Book: {title}, pages: {pages}";
            Console.WriteLine(sentence);
            #endregion
        }
    }
}
