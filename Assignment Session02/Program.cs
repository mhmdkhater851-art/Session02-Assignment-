namespace Assignment_Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //1- Create a Book class with a Title (string) and Pages (int). 
            //Create a Book object and store it in a variable of type object.Print it.in a variable of type object.
            // Print it.

            ///Book book_1 = new Book();
            ///object obj = book_1;
            ///Console.WriteLine(obj.ToString()); 
            #endregion

            #region Q02
            // 1- Using the Book class above, print the result of calling ToString(),
            //Equals() (compare book with itself),
            // GetHashCode(), and GetType() on book.

            ///Console.WriteLine(book_1.ToString());
            ///Console.WriteLine(book_1.Equals(book_1));
            ///Console.WriteLine(book_1.GetHashCode());
            ///Console.WriteLine(book_1.GetType());
            #endregion

            #region Q03
            // Compile-time error: cannot assign a string to an int.
            // Fixed:
            //int pages = 464;
            #endregion

            #region Q04
            //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot
            //divide by zero", and then prints "Done" in a finally block.

            //try
            //{
            //    int num01 = 10;
            //    int num02 = 0;
            //    Console.WriteLine(num01/num02);

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion

            #region Q05
            // 5- Declare an int pages = 300; then store it in a double variable without using a cast.

            //int pages = 300;
            //double pagesAsDouble = pages;
            #endregion

            #region Q06
            // 6- Declare a double price = 49.99; then convert it into an int using a cast.

            //double price = 49.99;
            //int priceAsInt = (int)price;
            #endregion

            #region Q07
            // 7- Given string pagesText = "464";, convert it into an int using the Convert class.

            string pagesText = "464";
            int pagesAsInt = Convert.ToInt32(pagesText);
            #endregion
        }
    }
}
