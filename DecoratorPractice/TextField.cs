using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPractice
{
    class TextField : Widget
    {
        private int width;
        private int height;

        public TextField(int w, int h)
        {
            width = w;
            height = h;
        }
        public void draw()
        {
            Console.WriteLine("TextField: Width: {0}, Height: {1}", width, height);
        }
    }
}
