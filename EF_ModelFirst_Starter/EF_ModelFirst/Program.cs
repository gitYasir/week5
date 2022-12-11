using EF_ModelFirst;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EF_ModelFirst {
    class Program {
        static void Main( string[] args ) {


            Customer custstomer = new() {
                CustomerId = "2",
                ContactName = "Ibra",
                City = "Abuja",
                PostalCode = "XXXX-XXX",
                Country = "Nigeria"
            };

            CustomerManager.UpdateCustomer( custstomer );


        }
    }
}
