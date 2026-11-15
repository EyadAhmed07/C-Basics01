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


            #region Question06
            double price = 49.99;
            int Price = (int)price;
            Console.WriteLine(Price);
            #endregion


            #region Question07
            string pagesText = "464";
            int pagenum=Convert.ToInt32(pagesText);
            #endregion


            #region Question08
            string yearText = "2023";
            int Year = int.Parse(yearText);
            String badText = "abc";
            bool x = int.TryParse(badText, out Year);
            if (x)
                Console.WriteLine("Valid number");
            else
                Console.WriteLine("Invalid number");
            #endregion


            #region Question09
            int _Pages = 464;
            string strPage=_Pages.ToString();
            Console.WriteLine(strPage.GetType());
            #endregion


            #region Question10
            int copies = 100;
            object obj = copies;
            int newcopies = (int)obj;
            Console.WriteLine(obj);
            Console.WriteLine(newcopies);
            #endregion


            #region Question11
            int?year= null;
            Console.WriteLine(year.HasValue);
            year = 2023;
            Console.WriteLine(year.Value);
            #endregion


            #region Question12
            string? reviewer = null;
            Console.WriteLine(reviewer);
            #endregion


            #region Question13
            Book? _book = null;
            Console.WriteLine(_book?.title);
            #endregion


            #region Question14
            Console.WriteLine(_book?.title ?? "untitled");
            #endregion


            #region Question15
            string? name = "Ahmed";
            string Name = name;
            Console.WriteLine(Name);
            #endregion


        }
    }
}
