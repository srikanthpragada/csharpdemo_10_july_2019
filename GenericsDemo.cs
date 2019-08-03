using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class MyStack<T>
    {
        private T[] names = new T[10];
        private int top = 0;

        public void Push(T name)
        {
            names[top] = name;
            top++;
        }
        public T Pop()
        {
            top--;
            return names[top];
        }
    }

    class GenericsDemo
    {
        static void Main(string[] args)
        {
            MyStack<string> s = new MyStack<string>();
            s.Push("Abc");
            s.Push("Def");
            Console.WriteLine(s.Pop());

            MyStack<int> nums = new MyStack<int>();
            nums.Push(100);


        }
    }
}
