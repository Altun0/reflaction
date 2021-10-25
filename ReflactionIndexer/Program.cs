using System;
using System.Collections.Generic;

namespace ReflactionIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Book book1 = new Book();

            book1.id = 1;

            book1.Name = "Xemse";

            Library libraff = new Library(1000);

            libraff[100] = book1;

            Console.WriteLine(libraff[100]);

        }
    }
}
