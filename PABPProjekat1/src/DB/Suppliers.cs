using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PABPProjekat1.src.DB
{
    public class Suppliers
    {
        public List<Supplier> SupplierList { get; set; }

        public Supplier GetSupplier(string companyName)
        {
            Supplier s = null;

            using (SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT * FROM Suppliers WHERE CompanyName = '{0}';";

                    cmd.CommandText = string.Format(cmd.CommandText, companyName.ToString());

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        s = new Supplier();
                        s.Load(reader);
                    }
                }
            }

            return s;
        }
    }

    public class Supplier
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }

        // Aleksa: not a table column
        public string Password { get; set; }

        public void Load(SqlDataReader reader)
        {
            SupplierID = Int32.Parse(reader["SupplierID"].ToString());
            CompanyName = reader["CompanyName"].ToString();
            ContactName = reader["ContactName"].ToString();
            ContactTitle = reader["ContactTitle"].ToString();
            Address = reader["Address"].ToString();
            City = reader["City"].ToString();
            Region = reader["Region"].ToString();
            PostalCode = reader["PostalCode"].ToString();
            Country = reader["Country"].ToString();
            Phone = reader["Phone"].ToString();
            Fax = reader["Fax"].ToString();
            HomePage = reader["HomePage"].ToString();

            // Aleksa: escaping the special characters from number and postal code
            Password = ParsePassword(Phone, PostalCode);
        }

        private string ParsePassword(params string[] stringsToParse)
        {
            string value = String.Empty;

            for (int i = 0; i < stringsToParse.Count(); i++)
            {
                stringsToParse[i] = stringsToParse[i].Replace("(", string.Empty);
                stringsToParse[i] = stringsToParse[i].Replace(")", string.Empty);
                stringsToParse[i] = stringsToParse[i].Replace(" ", string.Empty);
                stringsToParse[i] = stringsToParse[i].Replace("-", string.Empty);

                value += stringsToParse[i];
            }

            return value;
        }
    }

}
