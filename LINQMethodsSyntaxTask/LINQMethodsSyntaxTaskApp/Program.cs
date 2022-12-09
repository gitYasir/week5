using LINQMethodsSyntaxTaskApp.Models;
using Microsoft.EntityFrameworkCore;

using ( var db = new NorthwindContext() ) {
    // 1.1
    //var query1 = db.Customers
    //       .Where( c => c.City == "Paris" || c.City == "London" );

    //foreach ( var person in query1 ) {
    //    Console.WriteLine( $"{person.CustomerId} {person.CompanyName} {person.Address} {person.City} {person.PostalCode} {person.Country}" );
    //}

    // 1.2
    //var query = db.Products
    //    .Where( q => q.QuantityPerUnit.Contains( "bottle" ) );

    //foreach ( var item in query ) {
    //    Console.WriteLine( item.ProductName );
    //}

    // 1.3
    //var query = db.Products
    //.Include( p => p.Supplier )
    //    .Where( q => q.QuantityPerUnit.Contains( "bottle" ) );

    //foreach ( var item in query ) {
    //    Console.WriteLine( $"{item.ProductName} {item.Supplier.CompanyName} {item.Supplier.Country}" );

    //}

    // 1.4
    //var query = db.Products
    //.Include( c => c.Category )
    //.GroupBy( p => p.Category.CategoryName )
    //.Select( s => new { CategoryName = s.Key, Count = s.Count() } )
    //.OrderByDescending( o => o.Count );

    //foreach ( var item in query ) {
    //    Console.WriteLine( $"Category Name: {item.CategoryName} No of Products: {item.Count}" );
    //}

    // 1.5
    //var query = db.Employees;

    //foreach ( var item in query ) {
    //    Console.WriteLine( $"{item.TitleOfCourtesy} {item.FirstName} {item.LastName} from {item.Country}" );
    //}

    // 1.6
    var query = db.Orders
        .Where( w => w.Freight >= 100 )
        .Where( w => w.ShipCountry == "USA" || w.ShipCountry == "UK" )
        .Count();

    Console.WriteLine( query );
}