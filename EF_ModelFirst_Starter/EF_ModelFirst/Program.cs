using EF_ModelFirst;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EF_ModelFirst {
    class Program {
        static void Main( string[] args ) {
            using ( var db = new SouthwindContext() ) {
                Customer cust = new() {
                    CustomerId = "5",
                    ContactName = "Steve",
                    City = "Luton",
                    PostalCode = "XXXX-XXX"
                };
                var query = db.Customers.Add( cust );
                db.SaveChanges();
            }
        }
    }
}
