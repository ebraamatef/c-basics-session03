using System.Text;

namespace Session_3__Assignment_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            Console.WriteLine("Declare string title = \"clean code\";. " +
                "Call title.ToUpper() and store it in a new variable upperTitle. " +
                "Print\r\nboth title and upperTitle to show that title " +
                "did not change.\r\n");


            string title = "clean code";
            string uptitle = title.ToUpper();
            Console.WriteLine(uptitle);
            Console.WriteLine(title);
            #endregion


            #region Q2
            Console.WriteLine("Declare two separate string variables, " +
                "both set to the literal \"Clean Code\". Use ReferenceEquals()\r\nto" +
                " check if they point to the same object in memory.\r\n");


            string v1 = "clean code";
            string v2 = "clean code";
            Console.WriteLine(ReferenceEquals(v1, v2));
            #endregion

            #region Q3
            Console.WriteLine("Create a StringBuilder," +
                " Append() the text \"Book List\", then Append() \" - Updated\" onto the same\r\nobject." +
                " Print the final result");
            StringBuilder bookList = new StringBuilder();

            bookList.Append("Book List");
            bookList.Append(" - Updated");

            Console.WriteLine(bookList);

            #endregion

            #region Q4

            Console.WriteLine("Using the StringBuilder from the question above, use Replace() to change \"Book List\" into \"Library\".\r\nPrint the result.\r\n");

            bookList.Replace("Book List", "Library");
               Console.WriteLine(bookList);

            #endregion

            #region Q5

            Console.WriteLine("Given string title = \"Clean Code\"; and int pages = 464;" +
                ", build the sentence \"Book: Clean Code,\r\nPages: 464\" using the + operator.\r\n");
            int pages = 464;

            string result = "Book: " + title + ",\nPages: " + pages;
            Console.WriteLine(result);

            #endregion

            #region Q6
            Console.WriteLine("Build the same sentence as above, but using string " +
                "interpolation ($\"...\").\r\n");

            Console.WriteLine($"Book: {title},\nPages: {pages}");


            #endregion
            #region Q7
            Console.WriteLine("Build the same sentence again, but using string.Format().\r\n");
             result = string.Format("Book: {0},Pages: {1}", title, pages);
            Console.WriteLine(result);


            #endregion

            #region Q8
            Console.WriteLine("Given int pages = 464;, write an if / " +
                "else statement that prints \"Long Book\" if pages is " +
                "greater than\r\n300, otherwise prints \"Short Book\".");
            if(pages > 300 )
            { Console.WriteLine("Long Book");
            }
            else  Console.WriteLine("Short Book");


            #endregion

            #region Q9
            Console.WriteLine("Given int pages = 464; and bool isAvailable" +
                " = true;, print \"You can borrow this book\" only if pages is\r\ngreater than 300 and " +
                "isAvailable is true. Use the && operator.\r\n");
            bool Available = true;

            if (pages > 300 && Available == true)
            {
                Console.WriteLine("You can borrow this book");
            }

            #endregion
            #region Q10
            Console.WriteLine("Given string title = \"Refactoring\";, write a  " +
                "switch statement that prints \"Great choice!\" " +
                "if the title is\r\n\"Clean Code\", \"Nice pick!\" " +
                "if it's \"Refactoring\", and \"Never heard of it\" for anything else.\r\n");

            title = "Refactoring";

            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion



            #region Q11
            Console.WriteLine("Given int pages = 464;, " +
                "use the ternary operator to store \"Long Book\" or \"Short Book\" " +
                "into a\r\nvariable sizeLabel (same rule as question 8: long if pages > 300)");
            pages = 464;

            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);



            #endregion


            #region Q12
            Console.WriteLine("Given string[] books = { \"Clean Code\", \"" +
                "The Pragmatic Programmer\"," +
                " \"Refactoring\" };, use a for loop\r\nto print each book with its " +
                "position number, l" +
                "ike 1. Clean Code.");
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
            #endregion
            #region Q13
            Console.WriteLine("Using the same books array, " +
                "use a while loop to print every book title.\r\n");
            int i = 0;

            while (i < books.Length)
            {
                Console.WriteLine(books[i]);
                i++;
            }

            #endregion
            #region Q14
            Console.WriteLine("Write a do-while loop that prints " +
                "\"Checking book...\" exactly 3 times.\r\n");
            i = 0;

            do
            {
                Console.WriteLine("Checking book...");
                i++;
            }
            while (i < 3);
            #endregion



            #region Q15
            Console.WriteLine("Using the same books array, use a " +
                "foreach loop to print every book title.\r\n");
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            #endregion

            #region Q16

            Console.WriteLine("Using the same books array," +
                " loop through it and print each title, but stop completely " +
                "(break) once\r\nyou reach \"Refactoring\".\r\n");
            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }

                Console.WriteLine(book);
            }
            #endregion

            #region Q17

            Console.WriteLine("Using the same books array, " +
                "print every title except \"The Pragmatic Programmer\" " +
                "(skip it with\r\ncontinue, don't stop the loop).\r\n");
            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }

                Console.WriteLine(book);
            }
            #endregion

            #region Q18
            Console.WriteLine("Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty,\r\nuse return to exit the method early instead of printing anything.");
            void PrintFirstBook()
            {
                if (books.Length == 0)
                {
                    return;
                }

                Console.WriteLine(books[0]);
            }

            PrintFirstBook();
            #endregion

        }
    }
}
