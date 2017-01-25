using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABPProjekat1.src.Orders
{
    public partial class OrdersForm : Form
    {
        DB.NorthwindDataSet nwds = new DB.NorthwindDataSet();
        BindingSource productsBindingSource = new BindingSource();
        BindingSource ordersBindingSource = new BindingSource();
        DB.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter orderDetailsTableAdapter = new DB.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter();
        DB.NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter = new DB.NorthwindDataSetTableAdapters.OrdersTableAdapter();
        int productId;
        DateTimePicker dtpDateFrom;
        DateTimePicker dtpDateTo;

        public OrdersForm()
        {
            InitializeComponent();
        }

        public OrdersForm(int productId, DateTimePicker dateFrom, DateTimePicker dateTo)
        {
            InitializeComponent();

            // Aleksa: positioning form to the center of the display
            this.StartPosition = FormStartPosition.CenterScreen;

            this.productId = productId;
            this.dtpDateFrom = dateFrom;
            this.dtpDateTo = dateTo;
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            // Aleksa TODO: implementation
            orderDetailsTableAdapter.Fill(nwds.Order_Details);
            ordersTableAdapter.Fill(nwds.Orders);
            productsBindingSource.DataSource = nwds.Products;
            ordersBindingSource.DataSource = nwds.Orders;

            // Aleksa: creating filter for selecting proper orders
            DataRow[] orderDetails = nwds.Order_Details.Select("ProductID = " + this.productId);
            if (orderDetails.Length > 0)
            {
                string filter = "OrderID IN (";
                int index = 0;
                foreach (DataRow order in orderDetails)
                {
                    if (index == 0)
                    {
                        filter += "'" + order["OrderID"] + "'";
                    }
                    else
                    {
                        filter += ", '" + order["OrderID"] + "'";
                    }
                    index++;
                }
                filter += ")";
                filter += " AND OrderDate >= '" + dtpDateFrom.Value.ToString("yyyy-MM-dd") + "'";
                filter += " AND OrderDate <= '" + dtpDateTo.Value.ToString("yyyy-MM-dd") + "'";

                ordersBindingSource.Filter = filter;
                dgvOrders.DataSource = ordersBindingSource;
            }
            else
            {
                MessageBox.Show("No orders for selected product!");
                this.Close();
            }

            // Aleksa: calculating sum of product in selected orders
            string select = "ProductID = " + productId + " AND OrderID IN (";
            int counter = 1;
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                if(dgvOrders.Rows[counter].Cells["OrderID"].Value != null)
                {
                    int orderId = (int)dgvOrders.Rows[counter].Cells["OrderID"].Value;
                    if (counter == 1)
                    {
                        select += "'" + orderId + "'";
                    }
                    else
                    {
                        select += ", '" + orderId + "'";
                    }
                    counter++;
                }
                
            }
            select += ")";

            decimal sum = 0;
            DataRow[] orderDetailsRows = nwds.Order_Details.Select(select);
            foreach (DataRow row in orderDetailsRows)
            {
                sum += (decimal)row["UnitPrice"];
            }

            lblSum.Text += sum.ToString();
        }

        private void OrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormProvider.FormProvider.CategoriesForm.Show();
        }
    }
}
