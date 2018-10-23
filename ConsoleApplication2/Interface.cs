using System;

namespace InterfaceDemo
{
    interface ISmartPhone       //Definition of Interface    
    {
        void OS();
        void AppStore();
    }

    //New Interface meant only for Apple Class    
    interface IFeatures
    {
        void TouchID();
    }

    class Apple: ISmartPhone, IFeatures
    {
        public void OS()
        {
            Console.WriteLine("OS Method: The OS of this smartphone is ios8");
        }

        public void AppStore()
        {
            Console.WriteLine("AppStore Method: The App Store of this smartphone is iTunes.");
        }

        //TouchID Method Implementation    
        public void TouchID()
        {
            Console.WriteLine("TouchID Method: This method provides Touch/Gesture control features.");
        }
    }

    class Samsung : ISmartPhone
    {
        //OS Method Implementation    
        public void OS()
        {
            Console.WriteLine("OS Method: The OS of this smartphone is Android");
        }

        //AppStore Method Implementation    
        public void AppStore()
        {
            Console.WriteLine("AppStore Method: The Application Store of this smartphone is Google Play");
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apple SmartPhone:");
            Apple apple = new Apple();
            apple.OS();
            apple.AppStore();
            apple.TouchID();

            Console.WriteLine("\n\n");
            Console.WriteLine("Samsung SmartPhone:");
            Samsung samsung = new Samsung();
            samsung.OS();
            samsung.AppStore();
            Console.ReadKey();
        }
    }
    }
}