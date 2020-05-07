﻿using System;
namespace Polymorphism
{
    public class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaserJet display dimension: 12x12");
        }
        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing...");
        }
    }
}