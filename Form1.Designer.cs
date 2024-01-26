namespace ListBoxComboExample
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.ProductListLb = new System.Windows.Forms.ListBox();
            this.ProductListBtn = new System.Windows.Forms.Button();
            this.ProductListLbl = new System.Windows.Forms.Label();
            this.RemoveItemBtn = new System.Windows.Forms.Button();
            this.MoveProductCb = new System.Windows.Forms.ComboBox();
            this.MoveProductLbl = new System.Windows.Forms.Label();
            this.MoveProductBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sayiLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(49, 110);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(100, 23);
            this.AddProductBtn.TabIndex = 0;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Location = new System.Drawing.Point(49, 61);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(93, 16);
            this.ProductNameLbl.TabIndex = 1;
            this.ProductNameLbl.Text = "Product Name";
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Location = new System.Drawing.Point(49, 82);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(100, 22);
            this.ProductNameTxt.TabIndex = 2;
            // 
            // ProductListLb
            // 
            this.ProductListLb.FormattingEnabled = true;
            this.ProductListLb.ItemHeight = 16;
            this.ProductListLb.Location = new System.Drawing.Point(156, 82);
            this.ProductListLb.Name = "ProductListLb";
            this.ProductListLb.Size = new System.Drawing.Size(120, 116);
            this.ProductListLb.TabIndex = 3;
            // 
            // ProductListBtn
            // 
            this.ProductListBtn.Location = new System.Drawing.Point(156, 205);
            this.ProductListBtn.Name = "ProductListBtn";
            this.ProductListBtn.Size = new System.Drawing.Size(120, 23);
            this.ProductListBtn.TabIndex = 4;
            this.ProductListBtn.Text = "Clear All";
            this.ProductListBtn.UseVisualStyleBackColor = true;
            this.ProductListBtn.Click += new System.EventHandler(this.ProductListBtn_Click);
            // 
            // ProductListLbl
            // 
            this.ProductListLbl.AutoSize = true;
            this.ProductListLbl.Location = new System.Drawing.Point(156, 60);
            this.ProductListLbl.Name = "ProductListLbl";
            this.ProductListLbl.Size = new System.Drawing.Size(76, 16);
            this.ProductListLbl.TabIndex = 5;
            this.ProductListLbl.Text = "Product List";
            // 
            // RemoveItemBtn
            // 
            this.RemoveItemBtn.Location = new System.Drawing.Point(156, 235);
            this.RemoveItemBtn.Name = "RemoveItemBtn";
            this.RemoveItemBtn.Size = new System.Drawing.Size(120, 23);
            this.RemoveItemBtn.TabIndex = 6;
            this.RemoveItemBtn.Text = "Remove Item";
            this.RemoveItemBtn.UseVisualStyleBackColor = true;
            this.RemoveItemBtn.Click += new System.EventHandler(this.RemoveItemBtn_Click);
            // 
            // MoveProductCb
            // 
            this.MoveProductCb.FormattingEnabled = true;
            this.MoveProductCb.Location = new System.Drawing.Point(292, 82);
            this.MoveProductCb.Name = "MoveProductCb";
            this.MoveProductCb.Size = new System.Drawing.Size(121, 24);
            this.MoveProductCb.TabIndex = 7;
            // 
            // MoveProductLbl
            // 
            this.MoveProductLbl.AutoSize = true;
            this.MoveProductLbl.Location = new System.Drawing.Point(292, 59);
            this.MoveProductLbl.Name = "MoveProductLbl";
            this.MoveProductLbl.Size = new System.Drawing.Size(90, 16);
            this.MoveProductLbl.TabIndex = 8;
            this.MoveProductLbl.Text = "Move Product";
            // 
            // MoveProductBtn
            // 
            this.MoveProductBtn.Location = new System.Drawing.Point(156, 265);
            this.MoveProductBtn.Name = "MoveProductBtn";
            this.MoveProductBtn.Size = new System.Drawing.Size(120, 23);
            this.MoveProductBtn.TabIndex = 9;
            this.MoveProductBtn.Text = "Move Product";
            this.MoveProductBtn.UseVisualStyleBackColor = true;
            this.MoveProductBtn.Click += new System.EventHandler(this.MoveProductBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sayiLbl
            // 
            this.sayiLbl.AutoSize = true;
            this.sayiLbl.Location = new System.Drawing.Point(84, 161);
            this.sayiLbl.Name = "sayiLbl";
            this.sayiLbl.Size = new System.Drawing.Size(0, 16);
            this.sayiLbl.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sayiLbl);
            this.Controls.Add(this.MoveProductBtn);
            this.Controls.Add(this.MoveProductLbl);
            this.Controls.Add(this.MoveProductCb);
            this.Controls.Add(this.RemoveItemBtn);
            this.Controls.Add(this.ProductListLbl);
            this.Controls.Add(this.ProductListBtn);
            this.Controls.Add(this.ProductListLb);
            this.Controls.Add(this.ProductNameTxt);
            this.Controls.Add(this.ProductNameLbl);
            this.Controls.Add(this.AddProductBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.ListBox ProductListLb;
        private System.Windows.Forms.Button ProductListBtn;
        private System.Windows.Forms.Label ProductListLbl;
        private System.Windows.Forms.Button RemoveItemBtn;
        private System.Windows.Forms.ComboBox MoveProductCb;
        private System.Windows.Forms.Label MoveProductLbl;
        private System.Windows.Forms.Button MoveProductBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label sayiLbl;
    }
}

