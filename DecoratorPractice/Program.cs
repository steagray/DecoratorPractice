using System;

namespace DecoratorPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            TextField textwidget = new TextField(10, 12);

            textwidget.draw();

            BorderDecorator bordDec = new BorderDecorator(textwidget);

            bordDec.draw();

            ScrollDecorator scrollDec = new ScrollDecorator(bordDec);

            scrollDec.draw();

            NewDecor newDec = new NewDecor(scrollDec);

            newDec.draw();
        }
    }
}
