using System.Threading.Channels;

namespace Assignment__1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01
            object book = new Book();
            Console.WriteLine(book);
            #endregion


            #region Question02
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            #endregion


            #region Question03
            /*
             -> compiletime error
             */
            int pages = 464;
            #endregion


            #region Question04

            int n1 = 10;
            int n2 = 0;

            try
            {
                int res = n1 / n2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            { 
                Console.WriteLine("Done");
            }


            #endregion


            #region Question05
            int Pages = 300;
            double _page = Pages;
            Console.WriteLine(_page);

            #endregion




        }
    }
}
