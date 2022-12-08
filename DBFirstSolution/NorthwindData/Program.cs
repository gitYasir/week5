using NorthwindData.Models;

using ( var db = new NorthwindContext() ) {
    #region
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
    #endregion

    #region LINQ query syntax

    //var records =
    //from customer in db.Customers
    //select customer;

    //foreach ( var row in records ) {
    //    Console.WriteLine( row );
    //}

    //var londonBerlinQuery1 =
    // from customer in db.Customers
    // where customer.City == "London" || customer.City == "Berlin"
    // select customer;

    //foreach ( var customer in londonBerlinQuery1 ) {
    //    Console.WriteLine( customer );
    //}

    //var londonBerlinQuery2 =
    // from customer in db.Customers
    // where customer.City == "London" || customer.City == "Berlin"
    // select new { Customer = customer.ContactName, Country = customer.Country };

    //foreach ( var customer in londonBerlinQuery2 ) {
    //    Console.WriteLine( $"{customer.Customer} lives in {customer.Country}" );
    //}

    //var orderProductsByUnitPrice =
    //from p in db.Products
    //orderby p.UnitPrice descending // default ascending if not specified
    //select p;

    //foreach ( var product in orderProductsByUnitPrice ) {
    //    Console.WriteLine( $"{product.ProductId} - {product.UnitPrice:C}" );
    //}

    var groupProductsByUnitInStockQuery =
    from p in db.Products
    group p by p.SupplierId into newGroup

    select new {
        SupplierID = newGroup.Key,
        UnitsInStock = newGroup.Sum( c => c.UnitsInStock )
    };

    foreach ( var result in groupProductsByUnitInStockQuery ) {
        Console.WriteLine( result );
    }

    #endregion

}