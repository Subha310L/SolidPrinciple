using System;
using System.Collections.Generic;
using System.Text;

namespace solid
{
    public class LibraryMembership
    {
        public virtual double GetMembership(double amount)
        {
            return amount +100;
        }
    }

    public class Deposit : LibraryMembership
    {
        public override double GetMembership(double amount)
        {
            return base.GetMembership(amount) + 50;
        }
    }
    public class Withdrawn : LibraryMembership
    {
        public override double GetMembership(double amount)
        {
            return base.GetMembership(amount) - 50;
        }
    }

}

