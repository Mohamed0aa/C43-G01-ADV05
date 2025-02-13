namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region accept BookFunctions Methods using following cases: 
            Book bb = new("978-3-16-148410-0", "The Great Programming Book", new string[] { "John Doe", "Jane Smith" }, new DateTime(2023, 10, 1), 29.9m);
            List<Book> list = new List<Book>();
             list.Add(bb);
            //a
            //BookDelegate fPtr = BookFunctions.GetTitle;

            //b
            //Func<Book, string> fPtr = BookFunctions.GetTitle;

            //c
            LibraryEngine.ProcessBooks(list, delegate (Book B)
            {
                return B.ISBN;
            });


            //D

            LibraryEngine.ProcessBooks(list, n => n.ISBN);



            #endregion
        }
    }
    
}
