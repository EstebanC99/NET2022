using System;

namespace Clases
{
    public class C
    {
        public void F() { Console.WriteLine("C.F"); }
        public virtual void G() { Console.WriteLine("C.G"); }
    }

    public class D : C
    {
        public void F() { Console.WriteLine("D.F"); }
        public void G() { Console.WriteLine("D.G"); }
    }

}
