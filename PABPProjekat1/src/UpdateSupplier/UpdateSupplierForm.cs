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
        public UpdateSupplierForm()
        {
            InitializeComponent();

            // Aleksa: positioning form to the center of the display
            this.StartPosition = FormStartPosition.CenterScreen;

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
            // Aleksa TODO: implement update

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
            // Aleksa TODO: implement save
            Supplier updatedSupplier = new Supplier();

            updatedSupplier.CompanyName = tbCompanyName.Text;
            updatedSupplier.ContactName = tbContactName.Text;
            updatedSupplier.ContactTitle = tbContactTitle.Text;
            updatedSupplier.Address = tbAddress.Text;
            updatedSupplier.City = tbCity.Text;
            updatedSupplier.Region = tbRegion.Text;
            updatedSupplier.PostalCode = tbPostalCode.Text;
            updatedSupplier.Country = tbCountry.Text;
            updatedSupplier.Phone = tbPhone.Text;
            updatedSupplier.Fax = tbFax.Text;
            updatedSupplier.HomePage = tbHomePage.Text;

            try
            {
                int res = Suppliers.UpdateSupplier(UserSession.Instance.Username, updatedSupplier);
                if (res == 1)
                {
                    MessageBox.Show("Profile updated successfully!");
                }
                else
                {
                    MessageBox.Show("Profile update failed! Error code: " + res);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Exception: " + exc.Message);
            }

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

            Suppliers suppliers = new Suppliers();
            Supplier supplier = suppliers.GetSupplier(UserSession.Instance.Username);

            if (supplier != null)
            {
                tbSupplierId.Text = supplier.SupplierID.ToString();
                tbCompanyName.Text = supplier.CompanyName;
                tbContactName.Text = supplier.ContactName;
                tbContactTitle.Text = supplier.ContactTitle;
                tbAddress.Text = supplier.Address;
                tbCity.Text = supplier.City;
                tbRegion.Text = supplier.Region;
                tbPostalCode.Text = supplier.PostalCode;
                tbCountry.Text = supplier.Country;
                tbPhone.Text = supplier.Phone;
                tbFax.Text = supplier.Fax;
                tbHomePage.Text = supplier.HomePage;
            }
        }

        private void UpdateSupplierForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormProvider.FormProvider.UpdateSupplierForm.Dispose();
            FormProvider.FormProvider.UpdateSupplierForm = null;
        }
    }
}
