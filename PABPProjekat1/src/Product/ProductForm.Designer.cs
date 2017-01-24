namespace PABPProjekat1.src.Product
{
    partial class ProductForm
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
            System.Windows.Forms.Label lblProductId;
            System.Windows.Forms.Label lblProductName;
            System.Windows.Forms.Label lblSupplierId;
            System.Windows.Forms.Label lblCategoryId;
            System.Windows.Forms.Label lblQuantityPerUnit;
            System.Windows.Forms.Label lblUnitPrice;
            System.Windows.Forms.Label lblUnitsInStock;
            System.Windows.Forms.Label lblUnitsOnOrder;
            System.Windows.Forms.Label lblReorderLevel;
            System.Windows.Forms.Label lblDiscontinued;
            this.tbProductId = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.tbUnitsInStock = new System.Windows.Forms.TextBox();
            this.tbUnitsOnOrder = new System.Windows.Forms.TextBox();
            this.tbReorderLevel = new System.Windows.Forms.TextBox();
            this.cbDiscontinued = new System.Windows.Forms.CheckBox();
            this.cbCategoryId = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbSupplierId = new System.Windows.Forms.ComboBox();
            lblProductId = new System.Windows.Forms.Label();
            lblProductName = new System.Windows.Forms.Label();
            lblSupplierId = new System.Windows.Forms.Label();
            lblCategoryId = new System.Windows.Forms.Label();
            lblQuantityPerUnit = new System.Windows.Forms.Label();
            lblUnitPrice = new System.Windows.Forms.Label();
            lblUnitsInStock = new System.Windows.Forms.Label();
            lblUnitsOnOrder = new System.Windows.Forms.Label();
            lblReorderLevel = new System.Windows.Forms.Label();
            lblDiscontinued = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new System.Drawing.Point(12, 15);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new System.Drawing.Size(61, 13);
            lblProductId.TabIndex = 1;
            lblProductId.Text = "Product ID:";
            // 
            // tbProductId
            // 
            this.tbProductId.Location = new System.Drawing.Point(108, 12);
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.Size = new System.Drawing.Size(154, 20);
            this.tbProductId.TabIndex = 2;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new System.Drawing.Point(12, 41);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new System.Drawing.Size(78, 13);
            lblProductName.TabIndex = 3;
            lblProductName.Text = "Product Name:";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(108, 38);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(154, 20);
            this.tbProductName.TabIndex = 4;
            // 
            // lblSupplierId
            // 
            lblSupplierId.AutoSize = true;
            lblSupplierId.Location = new System.Drawing.Point(12, 67);
            lblSupplierId.Name = "lblSupplierId";
            lblSupplierId.Size = new System.Drawing.Size(62, 13);
            lblSupplierId.TabIndex = 5;
            lblSupplierId.Text = "Supplier ID:";
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Location = new System.Drawing.Point(12, 93);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new System.Drawing.Size(66, 13);
            lblCategoryId.TabIndex = 7;
            lblCategoryId.Text = "Category ID:";
            // 
            // lblQuantityPerUnit
            // 
            lblQuantityPerUnit.AutoSize = true;
            lblQuantityPerUnit.Location = new System.Drawing.Point(12, 119);
            lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            lblQuantityPerUnit.Size = new System.Drawing.Size(90, 13);
            lblQuantityPerUnit.TabIndex = 9;
            lblQuantityPerUnit.Text = "Quantity Per Unit:";
            // 
            // tbQuantityPerUnit
            // 
            this.tbQuantityPerUnit.Location = new System.Drawing.Point(108, 116);
            this.tbQuantityPerUnit.Name = "tbQuantityPerUnit";
            this.tbQuantityPerUnit.Size = new System.Drawing.Size(154, 20);
            this.tbQuantityPerUnit.TabIndex = 10;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new System.Drawing.Point(12, 145);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new System.Drawing.Size(56, 13);
            lblUnitPrice.TabIndex = 11;
            lblUnitPrice.Text = "Unit Price:";
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Location = new System.Drawing.Point(108, 142);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(154, 20);
            this.tbUnitPrice.TabIndex = 12;
            // 
            // lblUnitsInStock
            // 
            lblUnitsInStock.AutoSize = true;
            lblUnitsInStock.Location = new System.Drawing.Point(12, 171);
            lblUnitsInStock.Name = "lblUnitsInStock";
            lblUnitsInStock.Size = new System.Drawing.Size(77, 13);
            lblUnitsInStock.TabIndex = 13;
            lblUnitsInStock.Text = "Units In Stock:";
            // 
            // tbUnitsInStock
            // 
            this.tbUnitsInStock.Location = new System.Drawing.Point(108, 168);
            this.tbUnitsInStock.Name = "tbUnitsInStock";
            this.tbUnitsInStock.Size = new System.Drawing.Size(154, 20);
            this.tbUnitsInStock.TabIndex = 14;
            // 
            // lblUnitsOnOrder
            // 
            lblUnitsOnOrder.AutoSize = true;
            lblUnitsOnOrder.Location = new System.Drawing.Point(12, 197);
            lblUnitsOnOrder.Name = "lblUnitsOnOrder";
            lblUnitsOnOrder.Size = new System.Drawing.Size(80, 13);
            lblUnitsOnOrder.TabIndex = 15;
            lblUnitsOnOrder.Text = "Units On Order:";
            // 
            // tbUnitsOnOrder
            // 
            this.tbUnitsOnOrder.Location = new System.Drawing.Point(108, 194);
            this.tbUnitsOnOrder.Name = "tbUnitsOnOrder";
            this.tbUnitsOnOrder.Size = new System.Drawing.Size(154, 20);
            this.tbUnitsOnOrder.TabIndex = 16;
            // 
            // lblReorderLevel
            // 
            lblReorderLevel.AutoSize = true;
            lblReorderLevel.Location = new System.Drawing.Point(12, 223);
            lblReorderLevel.Name = "lblReorderLevel";
            lblReorderLevel.Size = new System.Drawing.Size(77, 13);
            lblReorderLevel.TabIndex = 17;
            lblReorderLevel.Text = "Reorder Level:";
            // 
            // tbReorderLevel
            // 
            this.tbReorderLevel.Location = new System.Drawing.Point(108, 220);
            this.tbReorderLevel.Name = "tbReorderLevel";
            this.tbReorderLevel.Size = new System.Drawing.Size(154, 20);
            this.tbReorderLevel.TabIndex = 18;
            // 
            // lblDiscontinued
            // 
            lblDiscontinued.AutoSize = true;
            lblDiscontinued.Location = new System.Drawing.Point(12, 251);
            lblDiscontinued.Name = "lblDiscontinued";
            lblDiscontinued.Size = new System.Drawing.Size(72, 13);
            lblDiscontinued.TabIndex = 19;
            lblDiscontinued.Text = "Discontinued:";
            // 
            // cbDiscontinued
            // 
            this.cbDiscontinued.Location = new System.Drawing.Point(108, 246);
            this.cbDiscontinued.Name = "cbDiscontinued";
            this.cbDiscontinued.Size = new System.Drawing.Size(104, 24);
            this.cbDiscontinued.TabIndex = 20;
            this.cbDiscontinued.UseVisualStyleBackColor = true;
            this.cbDiscontinued.CheckedChanged += new System.EventHandler(this.cbDiscontinued_CheckedChanged);
            // 
            // cbCategoryId
            // 
            this.cbCategoryId.FormattingEnabled = true;
            this.cbCategoryId.Location = new System.Drawing.Point(108, 89);
            this.cbCategoryId.Name = "cbCategoryId";
            this.cbCategoryId.Size = new System.Drawing.Size(154, 21);
            this.cbCategoryId.TabIndex = 22;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(191, 278);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(99, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(9, 278);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbSupplierId
            // 
            this.cbSupplierId.FormattingEnabled = true;
            this.cbSupplierId.Location = new System.Drawing.Point(108, 64);
            this.cbSupplierId.Name = "cbSupplierId";
            this.cbSupplierId.Size = new System.Drawing.Size(154, 21);
            this.cbSupplierId.TabIndex = 26;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 308);
            this.Controls.Add(this.cbSupplierId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbCategoryId);
            this.Controls.Add(lblProductId);
            this.Controls.Add(this.tbProductId);
            this.Controls.Add(lblProductName);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(lblSupplierId);
            this.Controls.Add(lblCategoryId);
            this.Controls.Add(lblQuantityPerUnit);
            this.Controls.Add(this.tbQuantityPerUnit);
            this.Controls.Add(lblUnitPrice);
            this.Controls.Add(this.tbUnitPrice);
            this.Controls.Add(lblUnitsInStock);
            this.Controls.Add(this.tbUnitsInStock);
            this.Controls.Add(lblUnitsOnOrder);
            this.Controls.Add(this.tbUnitsOnOrder);
            this.Controls.Add(lblReorderLevel);
            this.Controls.Add(this.tbReorderLevel);
            this.Controls.Add(lblDiscontinued);
            this.Controls.Add(this.cbDiscontinued);
            this.Name = "ProductForm";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbProductId;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbQuantityPerUnit;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.TextBox tbUnitsInStock;
        private System.Windows.Forms.TextBox tbUnitsOnOrder;
        private System.Windows.Forms.TextBox tbReorderLevel;
        private System.Windows.Forms.CheckBox cbDiscontinued;
        private System.Windows.Forms.ComboBox cbCategoryId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbSupplierId;
    }
}