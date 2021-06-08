using System;
using System.Data.SqlClient;

namespace SQLTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=LAPTOP-IO7I9C50;Initial Catalog=AdventureWorksLT2019;Integrated Security=True";

            string sqlExpression = "SELECT ProductCategory.ProductCategoryID, ProductCategory.Name, COUNT(Product.StandardCost) AS Cost " +
                    "FROM SalesLT.Product INNER JOIN SalesLT.ProductCategory ON Product.ProductCategoryID = ProductCategory.ProductCategoryID " +
                    "WHERE Product.SellEndDate IS NOT NULL " +
                    "GROUP BY ProductCategory.ProductCategoryID, ProductCategory.Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object cost = reader.GetValue(2);

                        Console.WriteLine("{0} \t{1} \t{2}", id, name, cost);
                    }
                }

                reader.Close();
            }

            Console.Read();
        }
    }
}
