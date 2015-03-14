﻿namespace POS.UserInterfaceLayer.BasicData
{
    partial class FrmAdjustStockAddEdit
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
            this.cbx_StockTypeTO = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_StockTypeFrom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.num_Quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_AdjustReason = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_Product = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Store = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(983, 53);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(476, 21);
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 280);
            this.panl_Footer.Size = new System.Drawing.Size(983, 62);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(476, 7);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(373, 7);
            // 
            // cbx_StockTypeTO
            // 
            this.cbx_StockTypeTO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_StockTypeTO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_StockTypeTO.FormattingEnabled = true;
            this.cbx_StockTypeTO.Location = new System.Drawing.Point(489, 242);
            this.cbx_StockTypeTO.Name = "cbx_StockTypeTO";
            this.cbx_StockTypeTO.Size = new System.Drawing.Size(241, 24);
            this.cbx_StockTypeTO.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 75;
            this.label6.Text = "نوع الصنف - الى";
            // 
            // cbx_StockTypeFrom
            // 
            this.cbx_StockTypeFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_StockTypeFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_StockTypeFrom.FormattingEnabled = true;
            this.cbx_StockTypeFrom.Location = new System.Drawing.Point(133, 242);
            this.cbx_StockTypeFrom.Name = "cbx_StockTypeFrom";
            this.cbx_StockTypeFrom.Size = new System.Drawing.Size(241, 24);
            this.cbx_StockTypeFrom.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "نوع الصنف - من";
            // 
            // num_Quantity
            // 
            this.num_Quantity.Location = new System.Drawing.Point(133, 198);
            this.num_Quantity.Name = "num_Quantity";
            this.num_Quantity.Size = new System.Drawing.Size(241, 22);
            this.num_Quantity.TabIndex = 72;
            this.num_Quantity.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "الكمية";
            // 
            // cbx_AdjustReason
            // 
            this.cbx_AdjustReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_AdjustReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_AdjustReason.FormattingEnabled = true;
            this.cbx_AdjustReason.Location = new System.Drawing.Point(133, 120);
            this.cbx_AdjustReason.Name = "cbx_AdjustReason";
            this.cbx_AdjustReason.Size = new System.Drawing.Size(241, 24);
            this.cbx_AdjustReason.TabIndex = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(592, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 156);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الباتشات";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatchNumber,
            this.ExpiryDate});
            this.dataGridView1.Location = new System.Drawing.Point(25, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(264, 123);
            this.dataGridView1.TabIndex = 54;
            // 
            // BatchNumber
            // 
            this.BatchNumber.HeaderText = "رقم الباتش";
            this.BatchNumber.Name = "BatchNumber";
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.HeaderText = "تاريخ الصلاحيه";
            this.ExpiryDate.Name = "ExpiryDate";
            // 
            // cbx_Product
            // 
            this.cbx_Product.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Product.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Product.FormattingEnabled = true;
            this.cbx_Product.Location = new System.Drawing.Point(133, 157);
            this.cbx_Product.Name = "cbx_Product";
            this.cbx_Product.Size = new System.Drawing.Size(241, 24);
            this.cbx_Product.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "أسم الصنف";
            // 
            // cbx_Store
            // 
            this.cbx_Store.FormattingEnabled = true;
            this.cbx_Store.Location = new System.Drawing.Point(133, 75);
            this.cbx_Store.Name = "cbx_Store";
            this.cbx_Store.Size = new System.Drawing.Size(241, 24);
            this.cbx_Store.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "المخزن المحول منه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "سبب التسويه";
            // 
            // FrmAdjustStockAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(983, 342);
            this.Controls.Add(this.cbx_StockTypeTO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_StockTypeFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_Quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_AdjustReason);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbx_Product);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_Store);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdjustStockAddEdit";
            this.Controls.SetChildIndex(this.panl_Header, 0);
            this.Controls.SetChildIndex(this.panl_Footer, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cbx_Store, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbx_Product, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cbx_AdjustReason, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.num_Quantity, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cbx_StockTypeFrom, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cbx_StockTypeTO, 0);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_StockTypeTO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_StockTypeFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox num_Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_AdjustReason;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.ComboBox cbx_Product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Store;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
