using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.GenericsIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
        }
    }
}