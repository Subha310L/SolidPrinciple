using System;
using System.Collections.Generic;
using System.Text;
using solid;

namespace solid
{
    public interface ILibraryDataAccess
    {
        string GetCustomerName(String name);
    }

    public class LibraryDataAccess : ILibraryDataAccess
    {
        public LibraryDataAccess()    //Constructor
        {
        }

        public string GetCustomerName(string name)
        {
            return "Customer Name";
        }
    }

    public class CustomerDataAccessFactory
    {
        public static ILibraryDataAccess GetCustomerDataAccessObj()
        {
            return new LibraryDataAccess();
        }
    }

    public class CustomerLogic
    {
        ILibraryDataAccess _customerDataAccess;

        public CustomerLogic()
        {
            _customerDataAccess = CustomerDataAccessFactory.GetCustomerDataAccessObj();
        }

        public string GetCustomerName(String name)
        {
            return _customerDataAccess.GetCustomerName(name);
        }
    }
}
