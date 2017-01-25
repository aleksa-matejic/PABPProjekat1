using PABPProjekat1.src.Session;
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
        string productId;

        Type type;

        public enum Type
        {
            Update,
            Add
        }

        public ProductForm()
        {
            InitializeComponent();

            // Aleksa: positioning form to the center of the display
            this.StartPosition = FormStartPosition.CenterScreen;

            this.type = Type.Add;
        }

        public ProductForm(string ProductID)
        {
            InitializeComponent();

            // Aleksa: positioning form to the center of the display
            this.StartPosition = FormStartPosition.CenterScreen;

            type = Type.Update;

            this.productId = ProductID;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            switch (type)
            {
                case Type.Update:
                    Form_Load_Update();
                    break;
                case Type.Add:
                    Form_Load_Add();
                    break;
                default:
                    throw new NotImplementedException();
            }
            
        }
        public void Form_Load_Update()
        {
            this.productsBindingSource = new BindingSource();
            this.nwds = new DB.NorthwindDataSet();
            this.categoriesTableAdapter = new DB.NorthwindDataSetTableAdapters.CategoriesTableAdapter();
            this.productsTableAdapter = new DB.NorthwindDataSetTableAdapters.ProductsTableAdapter();
            this.suppliersTableAdapter = new DB.NorthwindDataSetTableAdapters.SuppliersTableAdapter();

            this.categoriesTableAdapter.Fill(nwds.Categories);
            this.productsTableAdapter.Fill(nwds.Products);
            this.suppliersTableAdapter.Fill(nwds.Suppliers);

            this.productsBindingSource.DataSource = nwds.Products;
            this.productsBindingSource.Filter = "ProductID = '" + this.productId + "'";

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
            btnDelete.Enabled = true;
            btnAddNew.Enabled = false;
            btnAddNew.Visible = false;

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

        public void Form_Load_Add()
        {
            this.productsBindingSource = new BindingSource();
            this.nwds = new DB.NorthwindDataSet();
            this.categoriesTableAdapter = new DB.NorthwindDataSetTableAdapters.CategoriesTableAdapter();
            this.productsTableAdapter = new DB.NorthwindDataSetTableAdapters.ProductsTableAdapter();
            this.suppliersTableAdapter = new DB.NorthwindDataSetTableAdapters.SuppliersTableAdapter();

            this.categoriesTableAdapter.Fill(nwds.Categories);
            this.productsTableAdapter.Fill(nwds.Products);
            this.suppliersTableAdapter.Fill(nwds.Suppliers);

            this.productsBindingSource.DataSource = nwds.Products;
            this.productsBindingSource.Filter = "SupplierID = '" + UserSession.Instance.SupplierID + "'";

            // Aleksa: disable ProductID and SupplierID
            foreach (Control x in this.Controls)
            {
                if (x.Name == "cbSupplierId" || x.Name == "tbProductId")
                {
                    ((Control)x).Enabled = false;
                }
            }

            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Visible = false;
            btnSave.Visible = false;
            btnDelete.Visible = false;

            cbSupplierId.DataSource = nwds.Suppliers;
            cbSupplierId.DisplayMember = "CompanyName";
            cbSupplierId.ValueMember = "SupplierID";
            cbSupplierId.DataBindings.Add("SelectedValue", productsBindingSource, "SupplierID");
            cbCategoryId.DataSource = nwds.Categories;
            cbCategoryId.DisplayMember = "CategoryName";
            cbCategoryId.ValueMember = "CategoryID";
            cbCategoryId.DataBindings.Add("SelectedValue", productsBindingSource, "CategoryID");
            cbCategoryId.SelectedIndex = 0;
        }

        private void cbDiscontinued_CheckedChanged(object sender, EventArgs e)
        {
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
            btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Aleksa: save changes to database
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
            btnDelete.Enabled = true;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            // Aleksa: save new product to database
            DB.NorthwindDataSet.ProductsRow row = nwds.Products.NewProductsRow();

            try
            {
                // Aleksa TODO: implement field validation
                row.ProductName = tbProductName.Text;
                row.SupplierID = Convert.ToInt32(cbSupplierId.SelectedValue.ToString());
                row.CategoryID = Convert.ToInt32(cbCategoryId.SelectedValue.ToString());
                row.QuantityPerUnit = tbQuantityPerUnit.Text;
                row.UnitPrice = Int32.Parse(tbUnitPrice.Text);
                row.UnitsInStock = short.Parse(tbUnitsInStock.Text);
                row.UnitsOnOrder = short.Parse(tbUnitsOnOrder.Text);
                row.ReorderLevel = short.Parse(tbReorderLevel.Text);
                row.Discontinued = cbDiscontinued.Checked;

                nwds.Products.AddProductsRow(row);

                int res = -1;
                res = productsTableAdapter.Update(nwds.Products);
                if (res == 1)
                {
                    MessageBox.Show("Product successfully added.");
                    // Aleksa TODO: clear fields instead of closing form
                    this.Close();
                }
                else
                {
                    throw new Exception("Product not added!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormProvider.FormProvider.CategoriesForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Aleksa TODO: implementation
            try
            {
                DataRow row = ((DataRowView)productsBindingSource.Current).Row;
                row.Delete();
                productsBindingSource.EndEdit();
                int res = -1;
                res = productsTableAdapter.Update(nwds.Products);
                if (res == 1)
                {
                    MessageBox.Show("Product successfully deleted.");
                    this.Close();
                }
                else
                {
                    throw new Exception("Product not deleted!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
