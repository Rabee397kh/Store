namespace Store.Screens.Customers
{
    partial class ManageCustomers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addCustomerBtnFocus = new System.Windows.Forms.Button();
            this.customersNums = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customerSearchTxt = new System.Windows.Forms.TextBox();
            this.productsCountLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerGrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.noteTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerImg = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerNameTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.companyTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.yesRd = new System.Windows.Forms.RadioButton();
            this.noRd = new System.Windows.Forms.RadioButton();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addCustomerBtnFocus);
            this.panel1.Controls.Add(this.customersNums);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.customerSearchTxt);
            this.panel1.Controls.Add(this.productsCountLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.customerGrid);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 606);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // addCustomerBtnFocus
            // 
            this.addCustomerBtnFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addCustomerBtnFocus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addCustomerBtnFocus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerBtnFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerBtnFocus.Location = new System.Drawing.Point(502, 25);
            this.addCustomerBtnFocus.Margin = new System.Windows.Forms.Padding(6);
            this.addCustomerBtnFocus.Name = "addCustomerBtnFocus";
            this.addCustomerBtnFocus.Size = new System.Drawing.Size(203, 35);
            this.addCustomerBtnFocus.TabIndex = 51;
            this.addCustomerBtnFocus.Text = "Add new Customer";
            this.addCustomerBtnFocus.UseVisualStyleBackColor = false;
            this.addCustomerBtnFocus.Click += new System.EventHandler(this.addCustomerBtnFocus_Click);
            // 
            // customersNums
            // 
            this.customersNums.AutoSize = true;
            this.customersNums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersNums.Location = new System.Drawing.Point(147, 559);
            this.customersNums.Name = "customersNums";
            this.customersNums.Size = new System.Drawing.Size(0, 25);
            this.customersNums.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Customer Name",
            "Address"});
            this.comboBox1.Location = new System.Drawing.Point(18, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // customerSearchTxt
            // 
            this.customerSearchTxt.Location = new System.Drawing.Point(199, 25);
            this.customerSearchTxt.Name = "customerSearchTxt";
            this.customerSearchTxt.Size = new System.Drawing.Size(155, 22);
            this.customerSearchTxt.TabIndex = 10;
            this.customerSearchTxt.TextChanged += new System.EventHandler(this.customerSearchTxt_TextChanged);
            // 
            // productsCountLbl
            // 
            this.productsCountLbl.AutoSize = true;
            this.productsCountLbl.Location = new System.Drawing.Point(187, 516);
            this.productsCountLbl.Name = "productsCountLbl";
            this.productsCountLbl.Size = new System.Drawing.Size(0, 16);
            this.productsCountLbl.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customers  : ";
            // 
            // customerGrid
            // 
            this.customerGrid.AllowUserToAddRows = false;
            this.customerGrid.AllowUserToDeleteRows = false;
            this.customerGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGrid.Location = new System.Drawing.Point(18, 69);
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.ReadOnly = true;
            this.customerGrid.RowHeadersWidth = 51;
            this.customerGrid.RowTemplate.Height = 24;
            this.customerGrid.Size = new System.Drawing.Size(687, 463);
            this.customerGrid.TabIndex = 7;
            this.customerGrid.SelectionChanged += new System.EventHandler(this.customerGrid_SelectionChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1106, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "Address";
            // 
            // noteTxt
            // 
            this.noteTxt.Location = new System.Drawing.Point(1201, 213);
            this.noteTxt.Margin = new System.Windows.Forms.Padding(6);
            this.noteTxt.Multiline = true;
            this.noteTxt.Name = "noteTxt";
            this.noteTxt.Size = new System.Drawing.Size(176, 152);
            this.noteTxt.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1109, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Note";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1106, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 38;
            this.label6.Text = "Email";
            // 
            // customerImg
            // 
            this.customerImg.BackColor = System.Drawing.Color.White;
            this.customerImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerImg.Location = new System.Drawing.Point(917, 338);
            this.customerImg.Name = "customerImg";
            this.customerImg.Size = new System.Drawing.Size(269, 170);
            this.customerImg.TabIndex = 37;
            this.customerImg.TabStop = false;
            this.customerImg.Click += new System.EventHandler(this.customerImg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(770, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1002, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 28);
            this.label3.TabIndex = 35;
            this.label3.Text = "Edit Customer";
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.BackColor = System.Drawing.Color.Transparent;
            this.addCustomerBtn.BackgroundImage = global::Store.Properties.Resources.add;
            this.addCustomerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerBtn.Location = new System.Drawing.Point(1102, 537);
            this.addCustomerBtn.Margin = new System.Windows.Forms.Padding(6);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(78, 81);
            this.addCustomerBtn.TabIndex = 34;
            this.addCustomerBtn.UseVisualStyleBackColor = false;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(931, 149);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(6);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(141, 22);
            this.phoneTxt.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(770, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Phone";
            // 
            // customerNameTxt
            // 
            this.customerNameTxt.Location = new System.Drawing.Point(931, 96);
            this.customerNameTxt.Margin = new System.Windows.Forms.Padding(6);
            this.customerNameTxt.Name = "customerNameTxt";
            this.customerNameTxt.Size = new System.Drawing.Size(141, 22);
            this.customerNameTxt.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(770, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Customer Name";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(1225, 151);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(6);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(141, 22);
            this.addressTxt.TabIndex = 43;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(1225, 96);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(6);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(141, 22);
            this.emailTxt.TabIndex = 42;
            // 
            // companyTxt
            // 
            this.companyTxt.Location = new System.Drawing.Point(931, 213);
            this.companyTxt.Margin = new System.Windows.Forms.Padding(6);
            this.companyTxt.Name = "companyTxt";
            this.companyTxt.Size = new System.Drawing.Size(141, 22);
            this.companyTxt.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(770, 213);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 24);
            this.label9.TabIndex = 44;
            this.label9.Text = "Company";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(770, 272);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 24);
            this.label10.TabIndex = 46;
            this.label10.Text = "Is Active";
            // 
            // yesRd
            // 
            this.yesRd.AutoSize = true;
            this.yesRd.Location = new System.Drawing.Point(931, 276);
            this.yesRd.Name = "yesRd";
            this.yesRd.Size = new System.Drawing.Size(52, 20);
            this.yesRd.TabIndex = 47;
            this.yesRd.TabStop = true;
            this.yesRd.Text = "Yes";
            this.yesRd.UseVisualStyleBackColor = true;
            // 
            // noRd
            // 
            this.noRd.AutoSize = true;
            this.noRd.Location = new System.Drawing.Point(1026, 276);
            this.noRd.Name = "noRd";
            this.noRd.Size = new System.Drawing.Size(46, 20);
            this.noRd.TabIndex = 48;
            this.noRd.TabStop = true;
            this.noRd.Text = "No";
            this.noRd.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editBtn.Enabled = false;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(944, 537);
            this.editBtn.Margin = new System.Windows.Forms.Padding(6);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(107, 81);
            this.editBtn.TabIndex = 49;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteBtn.Enabled = false;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(1225, 537);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(6);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(107, 81);
            this.deleteBtn.TabIndex = 50;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 633);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.noRd);
            this.Controls.Add(this.yesRd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.companyTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.noteTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customerImg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerNameTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCustomers";
            this.Text = "ManageCustomers";
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox customerSearchTxt;
        private System.Windows.Forms.Label productsCountLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView customerGrid;
        private System.Windows.Forms.Label customersNums;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox noteTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox customerImg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerNameTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox companyTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton yesRd;
        private System.Windows.Forms.RadioButton noRd;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addCustomerBtnFocus;
    }
}