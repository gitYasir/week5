using NorthwindData;
using NorthwindData.Models;
using System.Collections.Generic;

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

    //var groupProductsByUnitInStockQuery =
    //from p in db.Products
    //group p by p.SupplierId into newGroup

    //select new {
    //    SupplierID = newGroup.Key,
    //    UnitsInStock = newGroup.Sum( c => c.UnitsInStock )
    //};

    //foreach ( var result in groupProductsByUnitInStockQuery ) {
    //    Console.WriteLine( result );
    //}

    #endregion

    #region LINQ method syntax

    //var query = db.Customers
    //    .Where( c => c.City == "London" )
    //    .OrderBy( c => c.ContactName );

    #endregion

    #region LINQ method syntax Task

    //var query = db.Customers
    //    .Where( c => c.City == "London" || c.City == "Berlin" );

    //foreach ( var item in query ) {
    //    Console.WriteLine( item );
    //}

    //var groupBySupplierID = db.Products.GroupBy( p => p.SupplierId ).Select( group => group.Sum( p => p.UnitsInStock ) ).OrderBy( i => i.Value );

    //foreach ( var group in groupBySupplierID ) {
    //    Console.WriteLine( group );
    //}

    var order = db.Products.OrderBy( p => p.QuantityPerUnit ).ThenByDescending( p => p.ReorderLevel );

    foreach ( var item in order ) {
        Console.WriteLine( item );
    }
    #endregion
}
//  Count of even numbers (should be 4)
//  Count of odd numbers (should be 5)
//  Count of numbers of numbers that are 4 and below (should be 6)

//var nums = new List<int> { 3, 7, 1, 2, 8, 3, 0, 4, 5 };
//Console.WriteLine( nums.Count( num => num % 2 == 0 ) ); // returns 4
//Console.WriteLine( nums.Count( num => num % 2 != 0 ) ); // returns 5
//Console.WriteLine( nums.Where( num => num <= 4 ).Count() ); // returns 6

//List<Person> people = new List<Person>
//{
//    new Person { Name = "Fred", Age = 22 },
//    new Person { Name = "Bernard", Age = 35 },
//    new Person { Name = "Margaret", Age = 54 }
//};

//var youngPeople = people.Count( person => person.Age < 30 );

//Console.WriteLine( "Delegate: " + nums.Count( delegate ( int n ) { return n % 2 == 0; } ) );

