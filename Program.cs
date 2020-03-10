using System;
using System.Collections.Generic;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var Bobby = new Rose();
            var Dandy = new Dandelion();
            var Sunny = new Sunflower();
            var Vi = new Violet();

            FlowerShop MacsFlowerShop = new FlowerShop();
            List<IBirthDay> Arrangement = MacsFlowerShop.MakeBirthDayArrangement();
        }
    }
}