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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.gbCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.gbProducts.SuspendLayout();
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
            this.gbCategories.Location = new System.Drawing.Point(12, 99);
            this.gbCategories.Name = "gbCategories";
            this.gbCategories.Size = new System.Drawing.Size(888, 204);
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
            this.dgvCategories.Size = new System.Drawing.Size(876, 179);
            this.dgvCategories.TabIndex = 0;
            this.dgvCategories.SelectionChanged += new System.EventHandler(this.dgvCategories_SelectionChanged);
            // 
            // gbProducts
            // 
            this.gbProducts.Controls.Add(this.dgvProducts);
            this.gbProducts.Location = new System.Drawing.Point(12, 309);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(888, 204);
            this.gbProducts.TabIndex = 2;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "Products";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(6, 19);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(876, 179);
            this.dgvProducts.TabIndex = 0;
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
    }
}