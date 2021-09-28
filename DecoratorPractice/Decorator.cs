using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPractice
{
    abstract class Decorator : Widget
    {
        private Widget wid;

        public Decorator(Widget wid) 
        {
            this.wid = wid;
        }
        

        public virtual void draw()
        {
            wid.draw();
        }
    }
}
