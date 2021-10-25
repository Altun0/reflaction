using System;
namespace ReflactionIndexer
{
    public class Find
    {
        public int Id { get; set; }

        public string Name { get; set; }

        private Book[] _books;

        public Find(int size = 100)
        {
            _books = new Book[size];
        }
        public Book this[int Find]
        {
            get
            {
                try
                {
                    return _books[Find];
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
                    _books[Find] = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("out of range");
                }
            }
        }
    }
}
  