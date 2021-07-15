using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            capacity = size * 2;
            my_data = new T[capacity];
        }

        public vector(params T[] args)
        {
            size = args.Length;
            capacity = size * 2;
            my_data = new T[capacity];
            for (int i = 0; i < size; ++i)
            {
                my_data[i] = args[i];
            }
        }

        public void push_back(T value)
        {
            if (size == capacity)
            {
                capacity *= 2;
                T[] temp_data = my_data;
                my_data = new T[capacity];
                for (int i = 0; i < size; ++i)
                {
                    my_data[i] = temp_data[i];
                }
                my_data[size] = value;
            }
            else
            {
                my_data[size] = value;
            }
            size++;
        }

        public T this[int key]
        {
            get => my_data[key];
            set => my_data[key] = value;
        }

        public static vector<T> operator+ (vector<T> vec, vector<T> other)
        {
            T[] temp_data = new T[vec.size + other.size];
            for (int i = 0; i < vec.size; ++i)
            {
                temp_data[i] = vec.my_data[i];
            }
            for (int i = vec.size; i < other.size + vec.size; ++i)
            {
                temp_data[i] = other.my_data[i - vec.size];
            }
            vector<T> result = new vector<T>(temp_data);
            return result;
        }

        public void printVector()
        {
            for (int i = 0; i < size; ++i)
            {
                Console.WriteLine(my_data[i] + " ");
            }
        }

        public int get_size() { return size; }
        public int get_capacity() { return capacity; }

        private T[] my_data;
        private int size;
        private int capacity;
    }
}
