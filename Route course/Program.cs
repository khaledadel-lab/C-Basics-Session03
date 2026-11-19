using System.Globalization;
using System.Linq.Expressions;

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
            //2-Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory. 
            string title1 = "clean code";
            string title2 = "clean code";
            bool isSameReferences = object.ReferenceEquals(title1, title2);
            Console.WriteLine(isSameReferences);
            #endregion
        }
    }
}
