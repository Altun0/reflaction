using System;
namespace ReflactionIndexer
{
    public class count
    {
        public int Id { get; set; }

        public string Name { get; set; }

        private Book[] _books;

        public count(int size = 100)
        {
            _books = new Book[size];
        }
        public Book this[int Count]
        {
            get
            {
                try
                {
           
                    return _books[Count];
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
                    _books[Count] = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("out of range");
                }
            }
        }
    }
}
  
        

