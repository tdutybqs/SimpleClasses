using System;

namespace SimpleClasses
{
    public class vector<T>
    {
        public vector()
        {
            size = 0;
            capacity = 0;
            my_data = new T[capacity];
        }

        public vector(int size)
        {
            this.size = size;
            this.capacity = size * 2;
            my_data = new T[capacity];
        }

        public vector(params T[] args)
        {
            this.size = args.Length;
            this.capacity = this.size * 2;
            my_data = new T[capacity];
            for (int i = 0; i < size; ++i)
            {
                my_data[i] = args[i];
            }
        }

        public void printVector()
        {
            for (int i = 0; i < size; ++i)
            {
                Console.WriteLine(my_data[i] + " ");
            }
        }

        public int get_size() { return this.size; }
        public int get_capacity() { return this.capacity; }

        private T[] my_data;
        private int size;
        private int capacity;
    }


    class Program
    {
        static void Main(string[] args)
        {
            vector<int> vec;
            vec = new vector<int>(1,2,3);
            Console.WriteLine(vec.get_size());
            Console.WriteLine(vec.get_capacity());
            vec.printVector();
        }
    }
}
