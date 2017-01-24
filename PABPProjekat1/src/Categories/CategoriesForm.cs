using PABPProjekat1.src.Product;
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
        // Aleksa TODO: impelement on form show
        DB.NorthwindDataSet nwds;
        DB.NorthwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        DB.NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        BindingSource categoriesBindingSource;
        BindingSource productsBindingSource;

        public CategoriesForm()
        {
            InitializeComponent();

            // Aleksa: positioning form to the center of the display
            this.StartPosition = FormStartPosition.CenterScreen;

            this.lblUsername.ForeColor = Color.Blue;

            this.lblUsername.Font = new Font(lblUsername.Font, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);

            nwds = new DB.NorthwindDataSet();
            categoriesTableAdapter = new DB.NorthwindDataSetTableAdapters.CategoriesTableAdapter();
            productsTableAdapter = new DB.NorthwindDataSetTableAdapters.ProductsTableAdapter();
            categoriesBindingSource = new BindingSource();
            productsBindingSource = new BindingSource();

            this.nudMin.Value = 10;
            this.nudMax.Value = 100;
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = UserSession.Instance.Username;

            productsTableAdapter.Fill(nwds.Products);
            categoriesTableAdapter.Fill(nwds.Categories);

            productsBindingSource.DataSource = nwds.Products;
            categoriesBindingSource.DataSource = nwds.Categories;

            // Aleksa: creating filter for selecting proper categories
            DataRow[] products = nwds.Products.Select("SupplierID = " + UserSession.Instance.SupplierID);
            string filter = "CategoryID IN (";
            int index = 0;
            foreach(DataRow product in products)
            {
                if (index == 0)
                {
                    filter += "'" + product["CategoryID"] + "'";
                }
                else
                {
                    filter += ", '" + product["CategoryID"] + "'";
                }
                index++;
            }
            filter += ")";

            categoriesBindingSource.Filter = filter;

            dgvProducts.DataSource = productsBindingSource;
            dgvCategories.DataSource = categoriesBindingSource;
        }

        private void LoadChildData(DataGridViewRow row)
        {
            string categoryId = row.Cells["CategoryID"].Value.ToString();
            productsBindingSource.Filter = "SupplierID = " + UserSession.Instance.SupplierID + " AND CategoryID = " + categoryId;
        }

        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCategories.CurrentRow;
            Int32 tmp = (Int32)((DataRowView)categoriesBindingSource.Current).Row["CategoryID"];
            try
            {
                LoadChildData(row);
            }
            catch (NullReferenceException exc)
            {
                Console.Out.Write(exc.Message);
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
            // Aleksa: invoke update supplier form
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
            // Aleksa TODO: implementation
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            short selectedUnitsInStock = (short)((DataRowView)productsBindingSource.Current).Row["UnitsInStock"];
            string selectedProductName = (string)((DataRowView)productsBindingSource.Current).Row["ProductName"];
            // Aleksa TODO: use this in upper method
            // Int32 tmp = (Int32)((DataRowView)categoriesBindingSource.Current).Row["CategoryID"];

            // Aleksa: check if units in stock for selected product is lower that minimum and ask user if wanna order to max
            if (AutomaticOrderRequired())
            {
                DialogResult dialogResult = MessageBox.Show("Units in stock for '" + selectedProductName + "' are less then min! \nOrder units to max?", "Automatic order", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // Aleksa: save updates to database
                        int res = -1;
                        ((DataRowView)productsBindingSource.Current).Row["UnitsInStock"] = nudMax.Value;
                        productsBindingSource.EndEdit();
                        nwds.GetChanges();
                        res = productsTableAdapter.Update(nwds.Products);
                        if (res != 1)
                        {
                            MessageBox.Show("Order error!");
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Order error! " + exc.Message);
                    }
                }
            }
        }

        public bool AutomaticOrderRequired()
        {
            bool value = false;
            if(nudMin.Value < nudMax.Value)
            {
                short unitsInStock = (short)((DataRowView)productsBindingSource.Current).Row["UnitsInStock"];
                if (unitsInStock < nudMin.Value)
                {
                    value = true;
                }
            }
            else
            {
                // Aleksa TODO: implement automatic check
                MessageBox.Show("Min is grater than max. Please review your input!");
                value = false;
            }
            return value;
        }

        private void btnShowProductDetails_Click(object sender, EventArgs e)
        {
            // Aleksa TODO: uncomment this later maybe?
            // FormProvider.FormProvider.CategoriesForm.Hide();
            Int32 productId =  (Int32)((DataRowView)productsBindingSource.Current).Row["ProductID"];
            FormProvider.FormProvider.ProductForm = new ProductForm(productId.ToString());
            FormProvider.FormProvider.ProductForm.Show();
        }
    }
}
