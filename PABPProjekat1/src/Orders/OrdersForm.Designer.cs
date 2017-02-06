namespace PABPProjekat1.src.Orders
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOrders = new System.Windows.Forms.GroupBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.gbOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOrders
            // 
            this.gbOrders.Controls.Add(this.dgvOrders);
            this.gbOrders.Location = new System.Drawing.Point(12, 12);
            this.gbOrders.Name = "gbOrders";
            this.gbOrders.Size = new System.Drawing.Size(747, 464);
            this.gbOrders.TabIndex = 0;
            this.gbOrders.TabStop = false;
            this.gbOrders.Text = "Orders";
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(6, 19);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(735, 440);
            this.dgvOrders.TabIndex = 0;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(15, 496);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(34, 13);
            this.lblSum.TabIndex = 1;
            this.lblSum.Text = "Sum: ";
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Location = new System.Drawing.Point(663, 491);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(96, 23);
            this.btnCreateReport.TabIndex = 2;
            this.btnCreateReport.Text = "Create Report";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 532);
            this.Controls.Add(this.btnCreateReport);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.gbOrders);
            this.Name = "OrdersForm";
            this.Text = "Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersForm_FormClosing);
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.gbOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button btnCreateReport;
    }
}