using System;
using System.Collections.Generic;
using System.Data;
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

            NorthwindDataSet nwds = new NorthwindDataSet();
            NorthwindDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter = new NorthwindDataSetTableAdapters.SuppliersTableAdapter();

            suppliersTableAdapter.Fill(nwds.Suppliers);

            DataRow[] dataRows = nwds.Suppliers.Select("CompanyName = '" + companyName + "'");

            // Aleksa TODO: datarow more than one result
            if(dataRows.Length == 1)
            {
                s = new Supplier();
                s.Load(dataRows[0]);
            }

            return s;

            // Aleksa TODO: delete old code
            /*Supplier s = null;

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

            return s;*/
        }

        // Aleksa TODO: delete this method
        public static int UpdateSupplier(string companyName, Supplier updatedSupplier)
        {
            // Aleksa TODO: update supplier by standards of ADO.NET
            int res = -1;

            using (SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"UPDATE Suppliers
                                           SET CompanyName = '{0}'
                                              ,ContactName = '{1}'
                                              ,ContactTitle = '{2}'
                                              ,Address = '{3}'
                                              ,City = '{4}'
                                              ,Region = '{5}'
                                              ,PostalCode = '{6}'
                                              ,Country = '{7}'
                                              ,Phone = '{8}'
                                              ,Fax = '{9}'
                                              ,HomePage = '{10}'
                                         WHERE CompanyName = '{0}';";

                    cmd.CommandText = string.Format(cmd.CommandText, 
                        companyName.ToString(), 
                        updatedSupplier.ContactName,
                        updatedSupplier.ContactTitle,
                        updatedSupplier.Address,
                        updatedSupplier.City,
                        updatedSupplier.Region,
                        updatedSupplier.PostalCode,
                        updatedSupplier.Country,
                        updatedSupplier.Phone,
                        updatedSupplier.Fax,
                        updatedSupplier.HomePage);

                    res = cmd.ExecuteNonQuery();
                }

                return res;
            }
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

        // Aleksa TODO: delete old method
        /*public void Load(SqlDataReader reader)
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
        }*/

        public void Load(DataRow row)
        {
            SupplierID = row.Field<int>("SupplierID");
            CompanyName = row.Field<string>("CompanyName");
            ContactName = row.Field<string>("ContactName");
            ContactTitle = row.Field<string>("ContactTitle");
            Address = row.Field<string>("Address");
            City = row.Field<string>("City");
            Region = row.Field<string>("Region");
            PostalCode = row.Field<string>("PostalCode");
            Country = row.Field<string>("Country");
            Phone = row.Field<string>("Phone");
            Fax = row.Field<string>("Fax");
            HomePage = row.Field<string>("HomePage");

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
