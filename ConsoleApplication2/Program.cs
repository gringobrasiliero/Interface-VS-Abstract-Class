using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    abstract class iPhone
    {
        //Non-Abstract Method   
        public void Call()
        {
            Console.WriteLine("Call Method: This method provides Calling features");
        }

        //Abstract Method   
        public abstract void Model();
    }

    class iPhone5s : iPhone
    {
        //Abstract Method implementation
        public override void Model()
        {
            Console.WriteLine("This is a iPhone 5s.");
        }

        public void LaunchDate()
        {
            Console.WriteLine("Launch date: 9/20/2013");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            iPhone5s iphone5s = new iPhone5s();
            iphone5s.Call();
            iphone5s.Model();
            iphone5s.LaunchDate();
            Console.ReadKey();
        }
    }
}