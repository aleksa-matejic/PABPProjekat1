namespace PABPProjekat1.src.Categories
{
    partial class CategoriesForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gbCategories = new System.Windows.Forms.GroupBox();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnShowProductOrders = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnShowProductDetails = new System.Windows.Forms.Button();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.lblAutomaticOrder = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.gbCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.gbProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(725, 17);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            this.lblUsername.MouseEnter += new System.EventHandler(this.lblUsername_MouseEnter);
            this.lblUsername.MouseLeave += new System.EventHandler(this.lblUsername_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(825, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // gbCategories
            // 
            this.gbCategories.Controls.Add(this.dgvCategories);
            this.gbCategories.Location = new System.Drawing.Point(12, 47);
            this.gbCategories.Name = "gbCategories";
            this.gbCategories.Size = new System.Drawing.Size(635, 204);
            this.gbCategories.TabIndex = 2;
            this.gbCategories.TabStop = false;
            this.gbCategories.Text = "Categories";
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(6, 19);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(623, 179);
            this.dgvCategories.TabIndex = 0;
            this.dgvCategories.SelectionChanged += new System.EventHandler(this.dgvCategories_SelectionChanged);
            // 
            // gbProducts
            // 
            this.gbProducts.Controls.Add(this.lblToDate);
            this.gbProducts.Controls.Add(this.lblFromDate);
            this.gbProducts.Controls.Add(this.dtpDateTo);
            this.gbProducts.Controls.Add(this.dtpDateFrom);
            this.gbProducts.Controls.Add(this.btnShowProductOrders);
            this.gbProducts.Controls.Add(this.btnAddNewProduct);
            this.gbProducts.Controls.Add(this.btnShowProductDetails);
            this.gbProducts.Controls.Add(this.lblMax);
            this.gbProducts.Controls.Add(this.lblMin);
            this.gbProducts.Controls.Add(this.nudMax);
            this.gbProducts.Controls.Add(this.nudMin);
            this.gbProducts.Controls.Add(this.lblAutomaticOrder);
            this.gbProducts.Controls.Add(this.dgvProducts);
            this.gbProducts.Location = new System.Drawing.Point(12, 257);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(888, 321);
            this.gbProducts.TabIndex = 2;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "Products";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(667, 287);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(47, 13);
            this.lblToDate.TabIndex = 12;
            this.lblToDate.Text = "To date:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(667, 266);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(57, 13);
            this.lblFromDate.TabIndex = 11;
            this.lblFromDate.Text = "From date:";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(729, 287);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(116, 20);
            this.dtpDateTo.TabIndex = 10;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(729, 260);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(116, 20);
            this.dtpDateFrom.TabIndex = 9;
            // 
            // btnShowProductOrders
            // 
            this.btnShowProductOrders.Location = new System.Drawing.Point(670, 231);
            this.btnShowProductOrders.Name = "btnShowProductOrders";
            this.btnShowProductOrders.Size = new System.Drawing.Size(175, 23);
            this.btnShowProductOrders.TabIndex = 8;
            this.btnShowProductOrders.Text = "Show Product Orders";
            this.btnShowProductOrders.UseVisualStyleBackColor = true;
            this.btnShowProductOrders.Click += new System.EventHandler(this.btnShowProductOrders_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(670, 143);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(175, 23);
            this.btnAddNewProduct.TabIndex = 7;
            this.btnAddNewProduct.Text = "Add New Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnShowProductDetails
            // 
            this.btnShowProductDetails.Location = new System.Drawing.Point(670, 114);
            this.btnShowProductDetails.Name = "btnShowProductDetails";
            this.btnShowProductDetails.Size = new System.Drawing.Size(175, 23);
            this.btnShowProductDetails.TabIndex = 6;
            this.btnShowProductDetails.Text = "Show Product Details";
            this.btnShowProductDetails.UseVisualStyleBackColor = true;
            this.btnShowProductDetails.Click += new System.EventHandler(this.btnShowProductDetails_Click);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(667, 66);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(55, 13);
            this.lblMax.TabIndex = 5;
            this.lblMax.Text = "Max units:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(667, 40);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(52, 13);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Min units:";
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(725, 64);
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(120, 20);
            this.nudMax.TabIndex = 3;
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(725, 38);
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(120, 20);
            this.nudMin.TabIndex = 2;
            // 
            // lblAutomaticOrder
            // 
            this.lblAutomaticOrder.AutoSize = true;
            this.lblAutomaticOrder.Location = new System.Drawing.Point(722, 22);
            this.lblAutomaticOrder.Name = "lblAutomaticOrder";
            this.lblAutomaticOrder.Size = new System.Drawing.Size(83, 13);
            this.lblAutomaticOrder.TabIndex = 1;
            this.lblAutomaticOrder.Text = "Automatic Order";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(6, 19);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(623, 296);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 590);
            this.Controls.Add(this.gbProducts);
            this.Controls.Add(this.gbCategories);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblUsername);
            this.Name = "CategoriesForm";
            this.Text = "Categories";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoriesForm_FormClosing);
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            this.gbCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.gbProducts.ResumeLayout(false);
            this.gbProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox gbCategories;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label lblAutomaticOrder;
        private System.Windows.Forms.Button btnShowProductDetails;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Button btnShowProductOrders;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
    }
}