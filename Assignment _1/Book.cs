using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment__1
{
    internal class Book
    {
        public string title;
        public int pages;


        public override string ToString()
        {
            return ($"Title: {title}\nPages: {pages}");
        }
    }
    
        
}
