using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PABPProjekat1.src.DB
{
    public class Products
    {
        public List<Product> CategoriesList { get; set; }

        public Product GetProduct(string productId)
        {
            Product p = null;

            using (SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT * FROM Products WHERE ProductID = '{0}';";

                    cmd.CommandText = string.Format(cmd.CommandText, productId.ToString());

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        p = new Product();
                        p.Load(reader);
                    }
                }
            }

            return p;
        }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public int Discontinued { get; set; }

        public void Load(SqlDataReader reader)
        {
            ProductID = Int32.Parse(reader["ProductID"].ToString());
            ProductName = reader["ProductName"].ToString();
            SupplierID = Int32.Parse(reader["SupplierID"].ToString());
            CategoryID = Int32.Parse(reader["CategoryID"].ToString());
            QuantityPerUnit = reader["QuantityPerUnit"].ToString();
            UnitPrice = double.Parse(reader["UnitPrice"].ToString());
            UnitsInStock = Int32.Parse(reader["UnitsInStock"].ToString());
            UnitsOnOrder = Int32.Parse(reader["UnitsOnOrder"].ToString());
            ReorderLevel = Int32.Parse(reader["ReorderLevel"].ToString());
            Discontinued = Int32.Parse(reader["Discontinued"].ToString());
        }
    }
}
