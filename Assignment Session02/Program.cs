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

            Book book_1 = new Book();
            object obj = book_1;
            Console.WriteLine(obj.ToString()); 
            #endregion
        }
    }
}
