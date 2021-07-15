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
        ~vector()
        {
            clear();
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
            vector<T> result = new(temp_data);
            return result;
        }
        public void push_back(T value)
        {
            if (size == capacity)
            {
                capacity *= 2;
                T[] temp_data = my_data;
                my_data = null;
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
        public void clear()
        {
            my_data = null;
            size = 0;
            capacity = 0;
        }
        public bool empty() { return size == 0; }
        public void resize(int count)
        {
            if (size > count)
            {
                capacity = count * 2;
                size = count;
                T[] temp_data = my_data;
                my_data = null;
                my_data = new T[capacity];
                for (int i = 0; i < size; ++i)
                {
                    my_data[i] = temp_data[i];
                }
            }
            else if (size < count)
            {
                capacity = count * 2;
                T[] temp_data = my_data;
                my_data = null;
                my_data = new T[capacity];
                for (int i = 0; i < size; ++i)
                {
                    my_data[i] = temp_data[i];
                }
                size = count;
            }
        }
        public void reserve(int capacity)
        {
            if (this.capacity < capacity)
            {
                this.capacity = capacity;
                T[] temp_data = my_data;
                my_data = null;
                my_data = new T[capacity];
                for (int i = 0; i < size; ++i)
                {
                    my_data[i] = temp_data[i];
                }
            }
        }
        public void pop_back()
        {
            // So bad
            if (size > 1)
            {
                my_data[size - 1] = my_data[size];
                --size;
            }
        }
        public void printVector(string control = " ")
        {
            for (int i = 0; i < size; ++i)
            {
                if (i + 1 != size) Console.Write(my_data[i] + $"{control}");
                else Console.Write(my_data[i]);
            }
        }
        public int get_size() { return size; }
        public int get_capacity() { return capacity; }

        private T[] my_data;
        private int size;
        private int capacity;
    }
}
