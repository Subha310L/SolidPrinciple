using solid;
using Solid;
using System;
namespace Solid
{
    public class main
    {


        public static void Main(string[] args)
        {
            //single responsibility prinicple

            Librarydetails customer = new Librarydetails();
            customer.customercode(1);
            customer.CustomerName("Subha");
            customer.Customergenre("Fictional -English");
            AccountCreate accreate = new AccountCreate();
            accreate.Create("111");

            //open closed principle

            LibraryMembership Membership = new LibraryMembership();
            LibraryMembership Deposit = new Deposit();
            LibraryMembership Withdrawn = new Withdrawn();

            Membership.GetMembership(10000);
            Deposit.GetMembership(10000);
            Withdrawn.GetMembership(10000);



            //liskov substitution principle

            Books transaction = new Fiction();
            Console.WriteLine(transaction.Genre());
            transaction = new NonFiction();
            Console.WriteLine(transaction.Genre());
            Console.ReadLine();
            transaction = new Adventure();
            Console.WriteLine(transaction.Genre());
            Console.ReadLine();


            //interface segregation principle

            TransactionAccount ta = new TransactionAccount();
            ta.Active("Account is active. Transaction can be made");
            ta.InActive("Account is inactive. Transaction cannot be made");
            Console.ReadLine();
            /* //dependency 

             IBank activity = new Savings();
             Bankactivity acctype = new Bankactivity(activity);
             acctype.Displayacctype() ; */



        }
    }
}