﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiuGIT_Mar
{
    public class Program
    {
        static void Main(string[] args)
        {
            string color = "cacaniu";
            int size = 100;


            Apple apple1 = new Apple(color, size);

            Console.WriteLine("Marul " + apple1.color +" are dimensiunea de "+apple1.size+" cm");

            Console.ReadLine();
        }
    }
}
