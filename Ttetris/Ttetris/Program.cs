﻿using System;

namespace Ttetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);


            Point p1 = new Point();
            p1.x = 2;
            p1.y = 3;
            p1.c = '*';
            p1.Draw(); 
            Point p2 = new Point();
            p1.x = 4;
            p1.y = 5;
            p1.c = '@';
            p1.Draw();


            Console.ReadLine();
        }

       
    }
}
