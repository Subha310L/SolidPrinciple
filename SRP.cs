using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Librarydetails
    {
        public void customercode(int customerId)
        {
            Console.WriteLine(customerId);
        }



        public void CustomerName(String customername)
        {
            Console.WriteLine(customername);
        }


        public void Customergenre(String customergenre)
        {
            Console.WriteLine(customergenre);
        }
    }

    public class AccountCreate
    {
        public void Create(String libraryID)
        {
            Console.WriteLine("Customer library ID :" + libraryID);
        }


    }
}

