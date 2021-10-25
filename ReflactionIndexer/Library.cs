using System;
namespace ReflactionIndexer
{
    public class Library
    {
       
        public int Id { get; set; }

        public string Name { get; set; }

        private Book[] _books;

        public Library(int size = 100)
        {
            _books = new Book[size];
        }
        public Book this[int remove]
        {
            get
            {
                try
                {
                    return _books[remove];
                }
                catch (Exception)
                {
                    return _books[0];
                }
            }
            set
            {
                try
                {
                    _books[remove] = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("out of range");
                }
            }
        }
    }
}
