using PABPProjekat1.src.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABPProjekat1.src.Categories
{
    public partial class CategoriesForm : Form
    {
        SqlConnection conn;
        SqlDataAdapter daCategories;
        SqlDataAdapter daProducts;
        DataSet ds;

        public CategoriesForm()
        {
            InitializeComponent();

            // Aleksa: positioning form to the center of the display
            this.StartPosition = FormStartPosition.CenterScreen;

            this.lblUsername.ForeColor = Color.Blue;

            this.lblUsername.Font = new Font(lblUsername.Font, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);

        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            // Aleksa TODO: load categories and products
            using (conn = DB.DB.GetConnection())
            {
                daCategories = new SqlDataAdapter("SELECT * FROM Categories", conn);
                daProducts = new SqlDataAdapter("SELECT * FROM Products", conn);

                ds = new DataSet();

                daCategories.Fill(ds, "Categories");
                daProducts.Fill(ds, "Products");

                ds.Tables["Categories"].Constraints.Add("CategoryID_PK", ds.Tables["Categories"].Columns["CategoryID"], true);
                ds.Relations.Add("Categories_Products", ds.Tables["Categories"].Columns["CategoryID"], ds.Tables["Products"].Columns["CategoryID"]);

                dgvCategories.DataSource = ds.Tables["Categories"];
            }

            //LoadChildData(0);
        }

        private void LoadChildData(int rowIndex)
        {
            lblUsername.Text = UserSession.Instance.Username;

            var parentRow = ds.Tables["Categories"].Rows[rowIndex];
            var childRows = parentRow.GetChildRows("Categories_Products");
            DataTable childTable = ds.Tables["Products"].Clone();

            foreach(var row in childRows)
            {
                childTable.ImportRow(row);
            }
            dgvProducts.DataSource = childTable;
        }

        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                LoadChildData(dgvCategories.CurrentRow.Index);
            }
            catch (NullReferenceException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.Instance.IsActive = false;

            // Aleksa: kill the categories form instead of hiding
            if (FormProvider.FormProvider.GetCategoriesForm() != null)
            {
                FormProvider.FormProvider.CategoriesForm.Close();
                FormProvider.FormProvider.CategoriesForm = null;
            }

            // Aleksa: kill the update supplier form instead of hiding
            if (FormProvider.FormProvider.GetUpdateSupplierForm() != null)
            {
                FormProvider.FormProvider.UpdateSupplierForm.Close();
                // Aleksa: this line is not needed since we have a null assigned in closing event method but just to be sure
                FormProvider.FormProvider.UpdateSupplierForm = null;
            }

            FormProvider.FormProvider.LoginForm.Show();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            // Aleksa TODO: create update supplier form and invoke it
            // MessageBox.Show("Update supplier invoked!");

            FormProvider.FormProvider.UpdateSupplierForm.Show();
            FormProvider.FormProvider.UpdateSupplierForm.Focus();
        }

        private void lblUsername_MouseEnter(object sender, EventArgs e)
        {
            this.lblUsername.ForeColor = Color.CadetBlue;
        }

        private void lblUsername_MouseLeave(object sender, EventArgs e)
        {
            this.lblUsername.ForeColor = Color.Blue;
        }

        private void CategoriesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Aleksa TODO: try to re-use code on log out and closing

            UserSession.Instance.IsActive = false;

            // Aleksa: kill the categories form instead of hiding
            if (FormProvider.FormProvider.GetCategoriesForm() != null)
            {
                FormProvider.FormProvider.CategoriesForm.Dispose();
                FormProvider.FormProvider.CategoriesForm = null;
            }

            // Aleksa: kill the update supplier form instead of hiding
            if (FormProvider.FormProvider.GetUpdateSupplierForm() != null)
            {
                FormProvider.FormProvider.UpdateSupplierForm.Close();
                FormProvider.FormProvider.UpdateSupplierForm = null;
            }

            FormProvider.FormProvider.LoginForm.Show();
        }

        private void Cleaning()
        {
           
        }
    }
}
