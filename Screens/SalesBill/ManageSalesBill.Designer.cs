namespace Store.Screens.SalesBill
{
    partial class ManageSalesBill
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.billNumTxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.noteTxt = new System.Windows.Forms.TextBox();
            this.clientCombo = new System.Windows.Forms.ComboBox();
            this.productsListView = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.salesBillGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.totalLB = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.totalNetLb = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.discountNu = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.salesBillGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNu)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Client";
            // 
            // billNumTxt
            // 
            this.billNumTxt.Location = new System.Drawing.Point(155, 37);
            this.billNumTxt.Name = "billNumTxt";
            this.billNumTxt.Size = new System.Drawing.Size(167, 30);
            this.billNumTxt.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(615, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(344, 30);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // noteTxt
            // 
            this.noteTxt.Location = new System.Drawing.Point(155, 126);
            this.noteTxt.Multiline = true;
            this.noteTxt.Name = "noteTxt";
            this.noteTxt.Size = new System.Drawing.Size(167, 85);
            this.noteTxt.TabIndex = 6;
            // 
            // clientCombo
            // 
            this.clientCombo.FormattingEnabled = true;
            this.clientCombo.Location = new System.Drawing.Point(615, 29);
            this.clientCombo.Name = "clientCombo";
            this.clientCombo.Size = new System.Drawing.Size(194, 33);
            this.clientCombo.TabIndex = 7;
            // 
            // productsListView
            // 
            this.productsListView.HideSelection = false;
            this.productsListView.LargeImageList = this.imageList1;
            this.productsListView.Location = new System.Drawing.Point(745, 251);
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(460, 440);
            this.productsListView.SmallImageList = this.imageList1;
            this.productsListView.TabIndex = 8;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.SelectedIndexChanged += new System.EventHandler(this.productsListView_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(70, 70);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // salesBillGridView
            // 
            this.salesBillGridView.AllowUserToAddRows = false;
            this.salesBillGridView.AllowUserToDeleteRows = false;
            this.salesBillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesBillGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.price,
            this.quantity,
            this.total,
            this.image});
            this.salesBillGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.salesBillGridView.Location = new System.Drawing.Point(12, 251);
            this.salesBillGridView.Name = "salesBillGridView";
            this.salesBillGridView.ReadOnly = true;
            this.salesBillGridView.RowHeadersWidth = 51;
            this.salesBillGridView.RowTemplate.Height = 40;
            this.salesBillGridView.Size = new System.Drawing.Size(694, 440);
            this.salesBillGridView.TabIndex = 9;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 125;
            // 
            // total
            // 
            this.total.HeaderText = "total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 125;
            // 
            // image
            // 
            this.image.HeaderText = "img";
            this.image.Image = global::Store.Properties.Resources.main_background;
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.image.MinimumWidth = 6;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 718);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total";
            // 
            // totalLB
            // 
            this.totalLB.AutoSize = true;
            this.totalLB.Location = new System.Drawing.Point(73, 718);
            this.totalLB.Name = "totalLB";
            this.totalLB.Size = new System.Drawing.Size(0, 25);
            this.totalLB.TabIndex = 11;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(285, 718);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(88, 25);
            this.lb.TabIndex = 12;
            this.lb.Text = "Discount";
            // 
            // totalNetLb
            // 
            this.totalNetLb.AutoSize = true;
            this.totalNetLb.Location = new System.Drawing.Point(647, 718);
            this.totalNetLb.Name = "totalNetLb";
            this.totalNetLb.Size = new System.Drawing.Size(0, 25);
            this.totalNetLb.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(540, 718);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Total Net";
            // 
            // discountNu
            // 
            this.discountNu.Location = new System.Drawing.Point(397, 716);
            this.discountNu.Name = "discountNu";
            this.discountNu.Size = new System.Drawing.Size(54, 30);
            this.discountNu.TabIndex = 16;
            this.discountNu.ValueChanged += new System.EventHandler(this.discountNu_ValueChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(745, 710);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(102, 41);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ManageSalesBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1217, 771);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.discountNu);
            this.Controls.Add(this.totalNetLb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.totalLB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salesBillGridView);
            this.Controls.Add(this.productsListView);
            this.Controls.Add(this.clientCombo);
            this.Controls.Add(this.noteTxt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.billNumTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageSalesBill";
            this.Text = "ManageSalesBill";
            this.Load += new System.EventHandler(this.ManageSalesBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesBillGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNu)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox billNumTxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox noteTxt;
        private System.Windows.Forms.ComboBox clientCombo;
        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView salesBillGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalLB;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label totalNetLb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown discountNu;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}