using EF_ModelFirst;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EF_ModelFirst {
    class Program {
        static void Main( string[] args ) {
            using ( var db = new SouthwindContext() ) {
                // create customer
                //Customer cust = new() {
                //    CustomerId = "5",
                //    ContactName = "Steve",
                //    City = "Luton",
                //    PostalCode = "XXXX-XXX"
                //};
                //var query = db.Customers.Add( cust );

                // delete customer
                //var query = db.Customers
                //    .Where( w => w.CustomerId == "1" ).ExecuteDelete();

                //update customer
                //var query = db.Customers
                //    .Where( w => w.CustomerId == "3" );

                //foreach ( var cust in query ) {
                //    cust.City = "Brighton";
                //}

                db.SaveChanges();
                // read current customers table records
                foreach ( var cust in db.Customers ) {
                    Console.WriteLine( $"Customer ID: {cust.CustomerId} Name: {cust.ContactName} City: {cust.City} Postcode: {cust.PostalCode}" );
                }

            }
        }
    }
}
