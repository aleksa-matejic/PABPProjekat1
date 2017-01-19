using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PABPProjekat1.src.DB
{
    public class Categories
    {
        public List<Category> CategoriesList { get; set; }

        public Category GetCategorie(string categoryId)
        {
            Category c = null;

            using (SqlConnection conn = DB.GetConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT * FROM Categories WHERE CategoryID = '{0}';";

                    cmd.CommandText = string.Format(cmd.CommandText, categoryId.ToString());

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        c = new Category();
                        c.Load(reader);
                    }
                }
            }

            return c;
        }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        // Aleksa TODO: image
        // public Image Picture { get; set; }

        public void Load(SqlDataReader reader)
        {
            CategoryID = Int32.Parse(reader["CategoryID"].ToString());
            CategoryName = reader["CategoryName"].ToString();
            Description = reader["Description"].ToString();
            // Aleksa TODO: change type if needed
            // Picture = Image.reader["Picture"].ToString();
        }
    }
}
