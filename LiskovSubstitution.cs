using System;
using System.Collections.Generic;
using System.Text;

namespace solid
{
    public abstract class Books
    {
        public abstract string Genre();
    }
    public class Fiction : Books
    {
        public override string Genre()
        {
            Console.WriteLine("Fiction in Column 1 ");
        }

    }
    public class NonFiction : Books
    {
        public override string Genre()
        {
            rConsole.WriteLine("NonFiction in Column 2")
        }

    }
    
    public class Adventure : Books
    {
        public override string Genre()
        {
            reConsole.WriteLine("Adventure in Column 3 ")
        }

    }
    
}
