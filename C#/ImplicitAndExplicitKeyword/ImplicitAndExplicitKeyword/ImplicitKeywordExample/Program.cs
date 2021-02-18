using System;

namespace ImplicitKeywordExample
{
    //https://www.dotnetperls.com/explicit
    class Machine
    {
        public int _value;
        public static implicit operator Widget(Machine m)
        {
            Widget w = new Widget();
            w._value = m._value * 2;
            return w;
        }
    }

    class Widget
    {
        public int _value;
        public static implicit operator Machine(Widget w)
        {
            Machine m = new Machine();
            m._value = w._value / 2;
            return m;
        }
    }

    class Program
    {
        static void Main()
        {
            Machine m = new Machine();
            m._value = 5;
            Console.WriteLine(m._value);

            // Implicit conversion from machine to widget.
            Widget w = m;
            Console.WriteLine(w._value);

            // Implicit conversion from widget to machine.
            Machine m2 = w;
            Console.WriteLine(m2._value);
        }
    }
}
