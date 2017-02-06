using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABPProjekat1.src.Report
{
    public partial class ReportForm : Form
    {
        string dateFrom;
        string dateTo;
        int productId;

        public ReportForm(int productId, string dateFrom, string dateTo)
        {
            InitializeComponent();

            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.productId = productId;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // Aleksa: this line is prevention from throwing exception
            this.ReportDataSet.EnforceConstraints = false;

            this.DataTable1TableAdapter.Fill(this.ReportDataSet.DataTable1);
            
            // Aleksa TODO: fix this

            // Aleksa: creating filter for selecting proper orders
            DB.NorthwindDataSet nwds = new DB.NorthwindDataSet();
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
                filter += " AND OrderDate >= '" + dateFrom + "'";
                filter += " AND OrderDate <= '" + dateTo + "'";
                this.DataTable1BindingSource.Filter = filter;

            }

            this.reportViewer1.RefreshReport();
        }
    }
}
