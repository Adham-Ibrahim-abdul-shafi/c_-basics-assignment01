using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace c__basics_Assignment01
{
    internal class Program 
    {

        static void Main(string[] args)
        {

            #region Q01
            // Create a Book class with a Title (string) and Pages (int). Create a Book object and store it
            // in a variable of type object.Print it.
            Book book1 = new Book();
            book1.title = "C# basics";
            book1.pages = 543;

            Console.WriteLine($"Title : {book1.title} , pages = {book1.pages}");
            Console.WriteLine();
            #endregion

            #region Q02
            
            /*
                Q02. Using the Book class above, print the result of calling ToString(), Equals() (compare book with
                itself), GetHashCode(), and GetType() on book.
            */
            Console.WriteLine(book1);

            Console.WriteLine(book1.Equals(new Book() { title = "C++ basics" , pages = 543}));
            Console.WriteLine(book1.Equals(new Book() { title = "C# basics", pages = 543 }));


            Console.WriteLine(book1.GetHashCode());
            Console.WriteLine(book1.GetType());
            Console.WriteLine();
            #endregion

            #region Q03
            /*
             * Q03 
                Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
                int pages = "464";
             * Answer:
                - it is a compile-time error
                - int pages = 464;
                
             */
            #endregion

            #region Q04
            // Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot
            // divide by zero", and then prints "Done" in a finally block.
            int number01 = 10;
            int zero = 0;
            try
            {
                int result01 = number01 / zero;
                Console.WriteLine(result01);
            }catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally { Console.WriteLine("Done"); }
            Console.WriteLine();
            #endregion

            #region Q05
            
            // Declare an int pages = 300; then store it in a double variable without using a cast.
            
            int pages = 300;
            double dPages = pages;
            
            #endregion

            #region Q06
            
            // Declare a double price = 49.99; then convert it into an int using a cast.
            
            double price = 49.99;
            int iPrice = (int)price;
            
            #endregion

            #region Q07
            // Given string pagesText = "464";, convert it into an int using the Convert class.
            
            string pagesText = "464";
            int pagesNumber = Convert.ToInt32 (pages);
            Console.WriteLine($"pagesText = {pagesText} , pagesNumber = {pagesNumber}");
            Console.WriteLine();
            #endregion

            #region Q08
            // Given string yearText = "2023";, convert it using int.Parse(). Then given string badText =
            // "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            
            string yearText = "2023";
            int yearNumber = int.Parse(yearText);
            
            string badText = "abc"; 

            bool isConvert = int.TryParse(badText, out int badTextNumber);
            if (isConvert == false)
            {
                Console.WriteLine("Invalid number");
            }
            Console.WriteLine();
            #endregion

            #region Q09
            // Given int pages = 464;, convert it into a string using ToString() and print its type using
            //GetType() to prove it's now a string.
            int page = 464;
            string pageText = page.ToString();
            Console.WriteLine(pageText.GetType());
            Console.WriteLine();
            #endregion

            #region Q10
            // Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            //variable, and print both.
            int copies = 100;
            object obj = copies;
            int objUnBox = (int)obj;
            Console.WriteLine($"copies = {copies} , copies after Boxing = {obj} , copies after UnBoxing = {obj}");
            #endregion

            #region Q11
            // Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.
            int? year = null;

            if(year != null)
            {
                Console.WriteLine($"year = {year}");
            }
            year = 2023;
            Console.WriteLine($"year = {year}");
            Console.WriteLine();
            #endregion

            #region Q12
            // Declare a string? reviewer = null;. Print whether it is null.
            string? reviewer = null;
            Console.WriteLine($"reviewer = {reviewer ?? "NULL" }");
            Console.WriteLine();
            #endregion

            #region Q13
            // Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the program, and print the result.
            Book? book = null;
            Console.WriteLine($"book title : {book?.title}");
            Console.WriteLine();
            #endregion

            #region Q14
            // Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??=
            //to assign title the value "Untitled" only if it's still null.
            Console.WriteLine($"book title : {book?.title ?? "Untitled"}");
            book = new Book();
            book?.title ??= "Untitled";
            Console.WriteLine($"book title : {book?.title }");
            Console.WriteLine();

            #endregion

            #region Q15
            // Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable
            //string confirmedName using the ! operator.
            string? name = "Ahmed";
            string confirmedName = name!;
            #endregion
        }
    }
}
