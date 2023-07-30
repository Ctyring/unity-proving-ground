using System;

namespace Script.CSharpToLua.Editor.input {
    public delegate void MyDelegate(string name);

    public class MyClass
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            MyDelegate myDelegate = new MyDelegate(obj.SayHello);

            myDelegate("John");
        }
    }
}