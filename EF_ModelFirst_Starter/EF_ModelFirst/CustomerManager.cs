using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ModelFirst {
    public class CustomerManager {
        public CustomerManager() {
        }

        public static void CreateCustomer( Customer cust ) {
            using ( var db = new SouthwindContext() ) {
                // create customer
                var query = db.Customers.Add( cust );
                db.SaveChanges();
            }
        }

        public static void ReadCustomers() {
            using ( var db = new SouthwindContext() ) {
                //read current customers table records
                foreach ( var cus in db.Customers ) {
                    Console.WriteLine( $"Customer ID: {cus.CustomerId} Name: {cus.ContactName} City: {cus.City} Postcode: {cus.PostalCode} Country: {cus.Country}" );
                }
            }
        }

        public static void UpdateCustomer( Customer updatedCust ) {
            using ( var db = new SouthwindContext() ) {
                // update customer
                var query = db.Customers
                 .Where( w => w.CustomerId == updatedCust.CustomerId );

                foreach ( var cust in query ) {
                    if ( cust.ContactName != updatedCust.ContactName ) {
                        cust.ContactName = updatedCust.ContactName;
                    }
                    else if ( cust.City != updatedCust.City ) {
                        cust.City = updatedCust.City;
                    }
                    else if ( cust.PostalCode != updatedCust.PostalCode ) {
                        cust.PostalCode = updatedCust.PostalCode;
                    }
                    else if ( cust.Country != updatedCust.Country ) {
                        cust.Country = updatedCust.Country;
                    }
                }

                db.SaveChanges();
            }
        }

        public static void DeleteCustomer( string id ) {
            using ( var db = new SouthwindContext() ) {
                // delete customer
                var query = db.Customers.Where( w => w.CustomerId == id ).ExecuteDelete();
                db.SaveChanges();
            }
        }
    }

}
