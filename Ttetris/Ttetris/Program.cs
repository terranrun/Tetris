using System;
using System.Threading;

namespace Ttetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);
            Figur s = new Stick(20, 5, '*');
           
            s.Draw();
            Thread.Sleep(500);
            s.Hide();
            s.Rotate();
            
           
            s.Draw();
            

            Thread.Sleep(500);

            s.Hide();
            s.Move(Direction.DOWN);
            s.Draw();

            Thread.Sleep(500);

            s.Hide();
            s.Move(Direction.DOWN);
            s.Draw();

            Thread.Sleep(500);
            s.Hide();
            s.Rotate();


            s.Draw();



            //Figur[] f = new Figur[2];
            //f[0] = new Square(2, 5, '*');
            //f[1] = new Stick(10, 15, '#');

            //foreach (Figur fig in f)
            //{
            //    fig.Draw();
            //}



            //Stick s1 = new Stick(10,15,'#');
            //s1.Draw();




            Console.ReadLine();
        }

       
    }
}
