﻿using System;
namespace Polymorphism
{
    public class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension: 9.5x12 ");
        }
        public override void Print()
        {
            Console.WriteLine("Canon printer printing...");
        }
    }
}