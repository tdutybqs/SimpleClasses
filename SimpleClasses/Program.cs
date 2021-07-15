using System;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            vector<int> vec = new vector<int>(1,2,3);
            Console.WriteLine("Size = " + vec.get_size());
            Console.WriteLine("Capcaity = " + vec.get_capacity());
            vec.printVector();
            vector<int> vec_2 = new vector<int>(4,5,6,7);
            Console.WriteLine("Size = " + vec_2.get_size());
            Console.WriteLine("Capcaity = " + vec_2.get_capacity());
            vec_2.printVector();
            vector<int> vec_3 = vec + vec_2;
            Console.WriteLine("Size = " + vec_3.get_size());
            Console.WriteLine("Capcaity = " + vec_3.get_capacity());
            //vec_3.printVector();
            vec_3[0] = 10;
            for (int i = 0; i < vec_3.get_size(); ++i)
            {
                Console.Write(vec_3[i] + " ");
            }
        }
    }
}
