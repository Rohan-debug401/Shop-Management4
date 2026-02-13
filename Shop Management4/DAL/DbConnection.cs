
using System.Data.SqlClient;

namespace Shop_Management4.DAL
{
    // This class is responsible for creating a connection to the database
    public class DbConnection
    {
        protected SqlConnection GetConnection()

            // This method creates and returns a new SQL connection using the specified connection string
        {
            return new SqlConnection(@"Data Source=(local)\MSSQLSERVER01;Initial Catalog=Shop Management1;Integrated Security=True");

        }
    }
}















































//using System.Data.SqlClient;   // This namespace is used to work with SQL Server database

//namespace Shop_Management4.DAL   // DAL = Data Access Layer (used to connect and talk to database)
//{
//    // This class is used to create a database connection
//    public class DbConnection
//    {
//        // This method creates and returns a SQL connection
//        // "protected" means it can be used in this class and in child classes (inheritance)
//        protected SqlConnection GetConnection()
//        {
//            // Creating a new SQL connection using connection string
//            // Data Source = SQL Server name
//            // Initial Catalog = Database name
//            // Integrated Security = Windows Authentication
//            return new SqlConnection(@"Data Source=(local)\MSSQLSERVER01;
//                                       Initial Catalog=Shop Management1;
//                                       Integrated Security=True");
//        }
//    }
//}

