using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABPProjekat1.src.Product
{
    public partial class ProductForm : Form
    {
        DB.NorthwindDataSet nwds;
        DB.NorthwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        DB.NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        DB.NorthwindDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        BindingSource categoriesBindingSource;
        BindingSource productsBindingSource;
        BindingSource suppliersBindingSource;

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(string ProductID)
        {
            InitializeComponent();
            this.productsBindingSource = new BindingSource();
            this.nwds = new DB.NorthwindDataSet();
            this.categoriesTableAdapter = new DB.NorthwindDataSetTableAdapters.CategoriesTableAdapter();
            this.productsTableAdapter = new DB.NorthwindDataSetTableAdapters.ProductsTableAdapter();
            this.suppliersTableAdapter = new DB.NorthwindDataSetTableAdapters.SuppliersTableAdapter();

            categoriesTableAdapter.Fill(nwds.Categories);
            productsTableAdapter.Fill(nwds.Products);
            suppliersTableAdapter.Fill(nwds.Suppliers);

            productsBindingSource.DataSource = nwds.Products;
            productsBindingSource.Filter = "ProductID = '" + ProductID + "'";
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // Aleksa: disable all textboxes and save button until user wanna update product
            foreach (Control x in this.Controls)
            {
                if (x is TextBox || x is ComboBox || x is CheckBox)
                {
                    ((Control)x).Enabled = false;
                }
            }

            btnUpdate.Enabled = true;
            btnSave.Enabled = false;

            tbProductId.DataBindings.Add("Text", productsBindingSource, "ProductID");
            tbProductName.DataBindings.Add("Text", productsBindingSource, "ProductName");
            cbSupplierId.DataSource = nwds.Suppliers;
            cbSupplierId.DisplayMember = "CompanyName";
            cbSupplierId.ValueMember = "SupplierID";
            cbSupplierId.DataBindings.Add("SelectedValue", productsBindingSource, "SupplierID");
            cbCategoryId.DataSource = nwds.Categories;
            cbCategoryId.DisplayMember = "CategoryName";
            cbCategoryId.ValueMember = "CategoryID";
            cbCategoryId.DataBindings.Add("SelectedValue", productsBindingSource, "CategoryID");
            tbQuantityPerUnit.DataBindings.Add("Text", productsBindingSource, "QuantityPerUnit");
            tbUnitPrice.DataBindings.Add("Text", productsBindingSource, "UnitPrice");
            tbUnitsInStock.DataBindings.Add("Text", productsBindingSource, "UnitsInStock");
            tbUnitsOnOrder.DataBindings.Add("Text", productsBindingSource, "UnitsOnOrder");
            tbReorderLevel.DataBindings.Add("Text", productsBindingSource, "ReorderLevel");
            cbDiscontinued.DataBindings.Add("Checked", productsBindingSource, "Discontinued");
            cbDiscontinued.DataBindings.Add("Text", productsBindingSource, "Discontinued");
        }

        private void cbDiscontinued_CheckedChanged(object sender, EventArgs e)
        {
            // Aleksa TODO: implementation
            ((DataRowView)productsBindingSource.Current).Row["Discontinued"] = cbDiscontinued.Checked;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Aleksa: enabling textboxes and disabling update button
            foreach (Control x in this.Controls)
            {
                if (x is TextBox || x is ComboBox || x is CheckBox)
                {
                    if (x.Name != "tbProductId" && x.Name != "cbSupplierId")
                    {
                        ((Control)x).Enabled = true;
                    }
                }
            }

            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Aleksa TODO: save changes to database
            int res = -1;
            try
            {
                productsBindingSource.EndEdit();
                nwds.GetChanges();
                res = productsTableAdapter.Update(nwds.Products);
                if (res != 1)
                {
                    throw new Exception("Product update unsuccessful!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }

            MessageBox.Show("Product updated successfully!");

            // Aleksa: disable all textboxes and save button until user wanna update product
            foreach (Control x in this.Controls)
            {
                if (x is TextBox || x is ComboBox || x is CheckBox)
                {
                    ((Control)x).Enabled = false;
                }
            }

            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
        }
    }
}
