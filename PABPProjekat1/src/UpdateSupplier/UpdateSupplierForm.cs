using PABPProjekat1.src.DB;
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

namespace PABPProjekat1.src.UpdateSupplier
{
    public partial class UpdateSupplierForm : Form
    {
        DB.NorthwindDataSet nwds;
        DB.NorthwindDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        BindingSource suppliersBindingSource;

        public UpdateSupplierForm()
        {
            InitializeComponent();

            // Aleksa: positioning form to the center of the display
            this.StartPosition = FormStartPosition.CenterScreen;

            nwds = new NorthwindDataSet();
            suppliersTableAdapter = new DB.NorthwindDataSetTableAdapters.SuppliersTableAdapter();
            suppliersBindingSource = new BindingSource();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Aleksa TODO: check if need to close (probably would be better to close because of updates in base, textboxes will have previous version)
            FormProvider.FormProvider.UpdateSupplierForm.Hide();

            // Aleksa: disable all textboxes and save button until user wanna update his information
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Enabled = false;
                }
            }

            btnUpdate.Enabled = true;
            btnSave.Enabled = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Aleksa: enabling textboxes and disabling update button
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    if (x.Name != "tbSupplierId")
                    {
                        ((TextBox)x).Enabled = true;
                    }
                }
            }

            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Aleksa: save changes to database
            int res = -1;
            try
            {
                suppliersBindingSource.EndEdit();
                nwds.GetChanges();
                res = suppliersTableAdapter.Update(nwds.Suppliers);
                if(res != 1)
                {
                    throw new Exception("Update unsuccessful!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }

            MessageBox.Show("Profile updated successfully!");

            // Aleksa: disable all textboxes and save button until user wanna update his information
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Enabled = false;
                }
            }

            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
        }

        private void UpdateSupplierForm_Load(object sender, EventArgs e)
        {
            // Aleksa: set windows title
            this.Text = UserSession.Instance.Username + " Profile";
            
            // Aleksa: disable all textboxes and save button until user wanna update his information
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Enabled = false;
                }
            }

            btnUpdate.Enabled = true;
            btnSave.Enabled = false;

            suppliersTableAdapter.Fill(nwds.Suppliers);
            suppliersBindingSource.DataSource = nwds.Suppliers;
            suppliersBindingSource.Filter = "SupplierID = '" + UserSession.Instance.SupplierID + "'";

            tbSupplierId.DataBindings.Add("Text", suppliersBindingSource, "SupplierID");
            tbCompanyName.DataBindings.Add("Text", suppliersBindingSource, "ContactName");
            tbContactName.DataBindings.Add("Text", suppliersBindingSource, "CompanyName");
            tbContactTitle.DataBindings.Add("Text", suppliersBindingSource, "ContactTitle");
            tbAddress.DataBindings.Add("Text", suppliersBindingSource, "Address");
            tbCity.DataBindings.Add("Text", suppliersBindingSource, "City");
            tbRegion.DataBindings.Add("Text", suppliersBindingSource, "Region");
            tbPostalCode.DataBindings.Add("Text", suppliersBindingSource, "PostalCode");
            tbCountry.DataBindings.Add("Text", suppliersBindingSource, "Country");
            tbPhone.DataBindings.Add("Text", suppliersBindingSource, "Phone");
            tbFax.DataBindings.Add("Text", suppliersBindingSource, "Fax");
            tbHomePage.DataBindings.Add("Text", suppliersBindingSource, "HomePage");
        }

        private void UpdateSupplierForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormProvider.FormProvider.UpdateSupplierForm.Dispose();
            FormProvider.FormProvider.UpdateSupplierForm = null;
        }
    }
}
