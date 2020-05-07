using System;
namespace Polymorphism
{
    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson display dimension: 10x11 ");
        }
        public override void Print()
        {
            Console.WriteLine("Epson printer printing...");
        }
    }
}