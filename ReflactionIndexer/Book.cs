using System;
namespace ReflactionIndexer
{
    public class Book:Object
    {
       
            public int id { get; set; }
        public object Id { get; private set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{ Id} { Name}";

        }


    }
}
