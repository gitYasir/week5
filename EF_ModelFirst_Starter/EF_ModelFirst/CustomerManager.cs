using EF_ModelFirst.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EF_ModelFirst {
    public class CustomerManager {
        private ICustomerServices _service;
        public CustomerManager() {
            _service = new CustomerServices();
        }
        public CustomerManager( ICustomerServices service ) {
            if ( service == null ) {
                throw new ArgumentException( "ICustomerService object cannot be null" );
            }
            _service = service;
        }

        public Customer SelectedCustomer { get; set; }

        public void SetSelectedCustomer( object selectedItem ) {
            SelectedCustomer = ( Customer ) selectedItem;
        }


        public void CreateCustomer( string customerId, string contactName, string country, string postCode, string city = null ) {
            var newCust = new Customer() { CustomerId = customerId, ContactName = contactName, PostalCode = postCode, City = city, Country = country };
            _service.CreateCustomer( newCust );
        }

        public List<Customer> ReadCustomers() {
            return _service.GetCustomerList();
        }

        public bool UpdateCustomer( Customer updatedCust ) {
            var cust = _service.GetCustomerById( updatedCust.CustomerId );
            if ( cust == null ) {
                Debug.WriteLine( $"Customer {updatedCust.CustomerId} not found" );
                return false;
            }
            cust.ContactName = updatedCust.ContactName;
            cust.City = updatedCust.City;
            cust.PostalCode = updatedCust.PostalCode;
            cust.Country = updatedCust.Country;

            _service.SaveCustomerChanges();
            return true;
        }

        public void DeleteCustomer( string id ) {
            var cust = _service.GetCustomerById( id );
            _service.RemoveCustomer( cust );
        }
    }

}
