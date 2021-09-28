using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPractice
{
    class BorderDecorator : Decorator
    {
        public BorderDecorator(Widget w) : base(w) { }

        public override void draw()
        {
            base.draw();
            Console.WriteLine("BorderDecorator.draw()");
        }


    }
}
