using System.Collections.Generic;
using System.Linq;

namespace EF_ModelFirst.Services {
    public class CustomerServices : ICustomerServices {
        private readonly SouthwindContext _context;

        public CustomerServices() {
            _context = new SouthwindContext();
        }
        public CustomerServices( SouthwindContext context ) {
            _context = context;
        }
        public void CreateCustomer( Customer c ) {
            _context.Customers.Add( c );
            _context.SaveChanges();
        }
        public Customer GetCustomerById( string customerId ) {
            return _context.Customers.Where( w => w.CustomerId == customerId ).FirstOrDefault();
        }

        public List<Customer> GetCustomerList() {
            return _context.Customers.ToList();
        }
        public void RemoveCustomer( Customer c ) {
            _context.Customers.Remove( c );
            _context.SaveChanges();
        }

        public void SaveCustomerChanges() {
            _context.SaveChanges();
        }
    }
}
