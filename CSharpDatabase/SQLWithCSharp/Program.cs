using SQLWithCSharp;
using System.Data.SqlClient;

var customers = new List<Customer>();

using ( var connection = new SqlConnection( "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" ) ) {
    connection.Open();

    #region read
    //using ( var readCommand = new SqlCommand( "SELECT * FROM Customers", connection ) ) {
    //SqlDataReader sqlReader = readCommand.ExecuteReader();

    //while ( sqlReader.Read() ) {
    //    var customer = new Customer {
    //        CustomerID = sqlReader[ "CustomerId" ].ToString(),
    //        ContactName = sqlReader[ "ContactName" ].ToString(),
    //        CompanyName = sqlReader[ "CompanyName" ].ToString(),
    //        City = sqlReader[ "City" ].ToString(),
    //        ContactTitle = sqlReader[ "ContactTitle" ].ToString()
    //    };
    //    customers.Add( customer );
    //}

    //foreach ( var customer in customers ) {
    //    Console.WriteLine(
    //        $"Customer {customer.FullName} " +
    //        $"has ID {customer.CustomerID} " +
    //        $"and lives in {customer.City}" );
    //}

    //sqlReader.Close();
    //}
    #endregion

    #region create
    //var newCustomer = new Customer {
    //    CustomerID = "MO",
    //    ContactName = "Mohammed Dahir",
    //    City = "Birmingham",
    //    CompanyName = "Sparta Global"
    //};
    //var sqlCreateString = $"INSERT INTO Customers (CustomerID, ContactName,City ,CompanyName ) VALUES ('{newCustomer.CustomerID}', '{newCustomer.ContactName}', '{newCustomer.City}', '{newCustomer.CompanyName}')";

    //int created;
    //using ( var createCommand = new SqlCommand( sqlCreateString, connection ) ) {
    //    created = createCommand.ExecuteNonQuery();
    //}
    #endregion

    #region update

    //var sqlUpdateString = $"UPDATE Customers SET City = 'London' WHERE customerid = 'MO';";

    //int updated;

    //using ( var updateCommand = new SqlCommand( sqlUpdateString, connection ) ) {
    //    updated = updateCommand.ExecuteNonQuery();
    //}
    //Console.WriteLine( updated );
    #endregion

    #region delete

    //var sqlDeleteString = $"DELETE FROM Customers WHERE customerid = 'MO';";

    //int deleted;

    //using ( var updateCommand = new SqlCommand( sqlDeleteString, connection ) ) {
    //    deleted = updateCommand.ExecuteNonQuery();
    //}
    //Console.WriteLine( deleted );

    #endregion
}