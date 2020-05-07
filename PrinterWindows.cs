using System;

namespace Polymorphism
{
    public class PrinterWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("Printer Windows");
        }
        public virtual void Print()
        {
            Console.WriteLine("Windows printer printing...");
        }
    }
}