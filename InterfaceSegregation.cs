using System;
using System.Collections.Generic;
using System.Text;
using solid;

namespace solid
{
    public interface AccountStatus
    {
        void Active(string active);
        void InActive(string inactive);
    }
    interface IOpeartion
    {
        void Success(string active);
    }

    public class AccountCondition : AccountStatus, IOpeartion

    {
        public void Active(string active)
        {
            Console.WriteLine("Account is active");
        }
        public void InActive(string inactive)
        {
            Console.WriteLine("Account is inactive");
        }
        public void Success(string active)
        {
            Console.WriteLine("They Account is active book can be rented");
        }

    }
    class TransactionAccount : AccountStatus
    {
        public void Active(string active)
        {
            Console.WriteLine("Rented books");
        }
        public void InActive(string inactive)
        {
            Console.WriteLine("Inactive books canot be rented");
        }
    }

}
