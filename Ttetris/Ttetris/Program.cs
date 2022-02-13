﻿using System;
using System.Threading;

namespace Ttetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Field.Width, Field.Height);
            Console.SetBufferSize(Field.Width, Field.Height);

            

            Field.Width = 20;

            FigureGenerator generator = new FigureGenerator(20, 0, '*');
            Figur currentFigure = generator.GetNewFigure();
           while(true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    HandleKey(currentFigure, key);
                }
                  
               
            }
            



        }

        private static void HandleKey(Figur currentFigure, ConsoleKeyInfo key)
        {
            switch(key.Key)
            {
                case ConsoleKey.LeftArrow:
                    currentFigure.TryMove(Direction.LEFT);
                    break;
                case ConsoleKey.RightArrow:
                    currentFigure.TryMove(Direction.RIGHT);
                    break;
                case ConsoleKey.DownArrow:
                    currentFigure.TryMove(Direction.DOWN);
                    break;
                case ConsoleKey.Spacebar:
                    
                    currentFigure.TryRotate();
                    
                    break;
            }
        }
    }

 
}
