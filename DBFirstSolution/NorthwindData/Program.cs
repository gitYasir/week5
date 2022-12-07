using NorthwindData.Models;

using ( var db = new NorthwindContext() ) {

    // select
    //foreach ( var customer in db.Customers ) {
    //    Console.WriteLine(
    //        $"Customer {customer.ContactName} has ID {customer.CustomerId} and lives in {customer.City}"
    //    );
    //}


    // add
    //var newCustomer = new Customer {
    //    CustomerId = "BLOGG",
    //    ContactName = "Joe Bloggs",
    //    CompanyName = "ToysRUs"
    //};

    //db.Customers.Add( newCustomer );
    //db.SaveChanges();

    //var selectedCustomer = db.Customers.Find( "BLOGG" );
    //Console.WriteLine( selectedCustomer );
}