using System;
using System.Collections.Generic;




namespace fruitsClass
{
    public class Fruits
    {
        public string fruitname;
        public string fruitcolor;

        public Fruits(string name,string color)
        {
            fruitname=name;
            fruitcolor=color;
        }
        public void DisplayFruits()
        {
            Console.WriteLine($" fruit name is {fruitname} and fruitcolor is {fruitcolor}");
        }
    }
}