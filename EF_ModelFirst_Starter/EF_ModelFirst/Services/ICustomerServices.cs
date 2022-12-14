using System.Collections.Generic;

namespace EF_ModelFirst.Services {
    public interface ICustomerServices {
        List<Customer> GetCustomerList();
        Customer GetCustomerById( string customerId );
        void CreateCustomer( Customer c );
        void SaveCustomerChanges();
        void RemoveCustomer( Customer c );
    }
}
