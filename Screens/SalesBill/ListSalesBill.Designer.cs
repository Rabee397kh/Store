namespace Store.Screens.SalesBill
{
    partial class ListSalesBill
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
            this.salesBillGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.salesBillCountLb = new System.Windows.Forms.Label();
            this.salesBillDetailsGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.billDetailesCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesBillGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBillDetailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // salesBillGridView
            // 
            this.salesBillGridView.AllowUserToAddRows = false;
            this.salesBillGridView.AllowUserToDeleteRows = false;
            this.salesBillGridView.BackgroundColor = System.Drawing.Color.White;
            this.salesBillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesBillGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.customername,
            this.total,
            this.discount,
            this.nettotal,
            this.billnumber,
            this.note,
            this.date});
            this.salesBillGridView.Location = new System.Drawing.Point(68, 85);
            this.salesBillGridView.Name = "salesBillGridView";
            this.salesBillGridView.ReadOnly = true;
            this.salesBillGridView.RowHeadersWidth = 51;
            this.salesBillGridView.RowTemplate.Height = 24;
            this.salesBillGridView.Size = new System.Drawing.Size(804, 547);
            this.salesBillGridView.TabIndex = 0;
            this.salesBillGridView.SelectionChanged += new System.EventHandler(this.salesBillGridView_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // username
            // 
            this.username.HeaderText = "user name";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 125;
            // 
            // customername
            // 
            this.customername.HeaderText = "customer name";
            this.customername.MinimumWidth = 6;
            this.customername.Name = "customername";
            this.customername.ReadOnly = true;
            this.customername.Width = 125;
            // 
            // total
            // 
            this.total.HeaderText = "total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 125;
            // 
            // discount
            // 
            this.discount.HeaderText = "discount";
            this.discount.MinimumWidth = 6;
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 125;
            // 
            // nettotal
            // 
            this.nettotal.HeaderText = "net total";
            this.nettotal.MinimumWidth = 6;
            this.nettotal.Name = "nettotal";
            this.nettotal.ReadOnly = true;
            this.nettotal.Width = 125;
            // 
            // billnumber
            // 
            this.billnumber.HeaderText = "bill number";
            this.billnumber.MinimumWidth = 6;
            this.billnumber.Name = "billnumber";
            this.billnumber.ReadOnly = true;
            this.billnumber.Width = 125;
            // 
            // note
            // 
            this.note.HeaderText = "note";
            this.note.MinimumWidth = 6;
            this.note.Name = "note";
            this.note.ReadOnly = true;
            this.note.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 648);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bills";
            // 
            // salesBillCountLb
            // 
            this.salesBillCountLb.AutoSize = true;
            this.salesBillCountLb.Location = new System.Drawing.Point(117, 648);
            this.salesBillCountLb.Name = "salesBillCountLb";
            this.salesBillCountLb.Size = new System.Drawing.Size(0, 16);
            this.salesBillCountLb.TabIndex = 2;
            // 
            // salesBillDetailsGridView
            // 
            this.salesBillDetailsGridView.AllowUserToAddRows = false;
            this.salesBillDetailsGridView.AllowUserToDeleteRows = false;
            this.salesBillDetailsGridView.BackgroundColor = System.Drawing.Color.White;
            this.salesBillDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesBillDetailsGridView.Location = new System.Drawing.Point(917, 85);
            this.salesBillDetailsGridView.Name = "salesBillDetailsGridView";
            this.salesBillDetailsGridView.ReadOnly = true;
            this.salesBillDetailsGridView.RowHeadersWidth = 51;
            this.salesBillDetailsGridView.RowTemplate.Height = 24;
            this.salesBillDetailsGridView.Size = new System.Drawing.Size(678, 547);
            this.salesBillDetailsGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sale Bills";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1208, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sale Bill Details";
            // 
            // billDetailesCount
            // 
            this.billDetailesCount.AutoSize = true;
            this.billDetailesCount.Location = new System.Drawing.Point(1010, 648);
            this.billDetailesCount.Name = "billDetailesCount";
            this.billDetailesCount.Size = new System.Drawing.Size(0, 16);
            this.billDetailesCount.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(914, 648);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bill Detailes";
            // 
            // ListSalesBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 673);
            this.Controls.Add(this.billDetailesCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salesBillDetailsGridView);
            this.Controls.Add(this.salesBillCountLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salesBillGridView);
            this.Name = "ListSalesBill";
            this.Text = "ListSalesBillcs";
            this.Load += new System.EventHandler(this.ListSalesBillcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesBillGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBillDetailsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesBillGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label salesBillCountLb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn customername;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn billnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridView salesBillDetailsGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label billDetailesCount;
        private System.Windows.Forms.Label label5;
    }
}