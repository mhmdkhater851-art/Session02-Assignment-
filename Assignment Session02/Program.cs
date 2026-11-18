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

            Console.WriteLine(book_1.ToString());
            Console.WriteLine(book_1.Equals(book_1));
            Console.WriteLine(book_1.GetHashCode());
            Console.WriteLine(book_1.GetType());
            #endregion
        }
    }
}
