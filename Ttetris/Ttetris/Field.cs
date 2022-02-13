using System;
using System.Collections.Generic;
using System.Text;

namespace Ttetris
{
    static class Field
    {
        private static int _width = 40;
        private static int _height = 30;

        public static int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                Console.SetWindowSize(_width, Field.Height);
                Console.SetBufferSize(_width, Field.Height);
            }
        }

        public static int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                Console.SetWindowSize(_width, Field.Height);
                Console.SetBufferSize(_width, Field.Height);
            }
        }

       
       

      
    }
}
