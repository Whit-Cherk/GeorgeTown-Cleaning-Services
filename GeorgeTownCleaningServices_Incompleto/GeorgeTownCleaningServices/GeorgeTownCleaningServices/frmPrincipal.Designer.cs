namespace GeorgeTownCleaningServices
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dtpOrderDate = new DateTimePicker();
            txtCustomerPhone = new TextBox();
            txtCustomerName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtSubTotalDresses = new TextBox();
            txtSubTotalPants = new TextBox();
            txtSubTotalShirts = new TextBox();
            label10 = new Label();
            txtDressPrice = new TextBox();
            txtPantsPrice = new TextBox();
            txtShirtPrice = new TextBox();
            label9 = new Label();
            txtDressesQuantity = new TextBox();
            txtPantsQuantity = new TextBox();
            txtShirtsQuantity = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnCalculate = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            groupBox3 = new GroupBox();
            label11 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpOrderDate);
            groupBox1.Controls.Add(txtCustomerPhone);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 148);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(181, 106);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(344, 26);
            dtpOrderDate.TabIndex = 5;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(181, 67);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(344, 26);
            txtCustomerPhone.TabIndex = 4;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(181, 27);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(344, 26);
            txtCustomerName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F);
            label3.Location = new Point(19, 114);
            label3.Name = "label3";
            label3.Size = new Size(86, 18);
            label3.TabIndex = 3;
            label3.Text = "Order Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F);
            label1.Location = new Point(19, 35);
            label1.Name = "label1";
            label1.Size = new Size(120, 18);
            label1.TabIndex = 1;
            label1.Text = "Customer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F);
            label2.Location = new Point(19, 75);
            label2.Name = "label2";
            label2.Size = new Size(121, 18);
            label2.TabIndex = 2;
            label2.Text = "Customer Phone:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSubTotalDresses);
            groupBox2.Controls.Add(txtSubTotalPants);
            groupBox2.Controls.Add(txtSubTotalShirts);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtDressPrice);
            groupBox2.Controls.Add(txtPantsPrice);
            groupBox2.Controls.Add(txtShirtPrice);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtDressesQuantity);
            groupBox2.Controls.Add(txtPantsQuantity);
            groupBox2.Controls.Add(txtShirtsQuantity);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(24, 276);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(540, 177);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Items";
            // 
            // txtSubTotalDresses
            // 
            txtSubTotalDresses.Location = new Point(412, 139);
            txtSubTotalDresses.Name = "txtSubTotalDresses";
            txtSubTotalDresses.ReadOnly = true;
            txtSubTotalDresses.RightToLeft = RightToLeft.Yes;
            txtSubTotalDresses.Size = new Size(79, 26);
            txtSubTotalDresses.TabIndex = 19;
            // 
            // txtSubTotalPants
            // 
            txtSubTotalPants.Location = new Point(412, 101);
            txtSubTotalPants.Name = "txtSubTotalPants";
            txtSubTotalPants.ReadOnly = true;
            txtSubTotalPants.RightToLeft = RightToLeft.Yes;
            txtSubTotalPants.Size = new Size(79, 26);
            txtSubTotalPants.TabIndex = 18;
            // 
            // txtSubTotalShirts
            // 
            txtSubTotalShirts.Location = new Point(412, 67);
            txtSubTotalShirts.Name = "txtSubTotalShirts";
            txtSubTotalShirts.ReadOnly = true;
            txtSubTotalShirts.RightToLeft = RightToLeft.Yes;
            txtSubTotalShirts.Size = new Size(79, 26);
            txtSubTotalShirts.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(412, 34);
            label10.Name = "label10";
            label10.Size = new Size(79, 18);
            label10.TabIndex = 16;
            label10.Text = "SubTotal:";
            // 
            // txtDressPrice
            // 
            txtDressPrice.Location = new Point(267, 134);
            txtDressPrice.Name = "txtDressPrice";
            txtDressPrice.ReadOnly = true;
            txtDressPrice.RightToLeft = RightToLeft.Yes;
            txtDressPrice.Size = new Size(87, 26);
            txtDressPrice.TabIndex = 15;
            // 
            // txtPantsPrice
            // 
            txtPantsPrice.Location = new Point(267, 96);
            txtPantsPrice.Name = "txtPantsPrice";
            txtPantsPrice.ReadOnly = true;
            txtPantsPrice.RightToLeft = RightToLeft.Yes;
            txtPantsPrice.Size = new Size(87, 26);
            txtPantsPrice.TabIndex = 14;
            // 
            // txtShirtPrice
            // 
            txtShirtPrice.Location = new Point(267, 62);
            txtShirtPrice.Name = "txtShirtPrice";
            txtShirtPrice.ReadOnly = true;
            txtShirtPrice.RightToLeft = RightToLeft.Yes;
            txtShirtPrice.Size = new Size(87, 26);
            txtShirtPrice.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(267, 34);
            label9.Name = "label9";
            label9.Size = new Size(87, 18);
            label9.TabIndex = 12;
            label9.Text = "Unit Price:";
            // 
            // txtDressesQuantity
            // 
            txtDressesQuantity.Location = new Point(132, 134);
            txtDressesQuantity.Name = "txtDressesQuantity";
            txtDressesQuantity.Size = new Size(69, 26);
            txtDressesQuantity.TabIndex = 11;
            txtDressesQuantity.TextChanged += txtShirtsQuantity_TextChanged;
            // 
            // txtPantsQuantity
            // 
            txtPantsQuantity.Location = new Point(132, 96);
            txtPantsQuantity.Name = "txtPantsQuantity";
            txtPantsQuantity.Size = new Size(69, 26);
            txtPantsQuantity.TabIndex = 10;
            txtPantsQuantity.TextChanged += txtShirtsQuantity_TextChanged;
            // 
            // txtShirtsQuantity
            // 
            txtShirtsQuantity.Location = new Point(132, 62);
            txtShirtsQuantity.Name = "txtShirtsQuantity";
            txtShirtsQuantity.Size = new Size(69, 26);
            txtShirtsQuantity.TabIndex = 9;
            txtShirtsQuantity.TextChanged += txtShirtsQuantity_TextChanged;
            txtShirtsQuantity.KeyPress += txtShirtsQuantity_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(132, 34);
            label8.Name = "label8";
            label8.Size = new Size(78, 18);
            label8.TabIndex = 8;
            label8.Text = "Quantity:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 34);
            label7.Name = "label7";
            label7.Size = new Size(56, 18);
            label7.TabIndex = 7;
            label7.Text = "Items:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 142);
            label6.Name = "label6";
            label6.Size = new Size(65, 18);
            label6.TabIndex = 2;
            label6.Text = "Dresses:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 104);
            label5.Name = "label5";
            label5.Size = new Size(49, 18);
            label5.TabIndex = 1;
            label5.Text = "Pants:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 70);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 0;
            label4.Text = "Shirts:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(24, 483);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(153, 48);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(213, 483);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(153, 48);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(412, 483);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(153, 48);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(619, 97);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(320, 434);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Invoice";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(133, 9);
            label11.Name = "label11";
            label11.Size = new Size(695, 52);
            label11.TabIndex = 11;
            label11.Text = "GeorgeTown Cleaning Services";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(967, 570);
            Controls.Add(label11);
            Controls.Add(groupBox3);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 11.25F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPrincipal";
            Text = "GeorgeTown Cleaning Services";
            Load += frmPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCustomerName;
        private Label label3;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpOrderDate;
        private TextBox txtCustomerPhone;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtDressesQuantity;
        private TextBox txtPantsQuantity;
        private TextBox txtShirtsQuantity;
        private TextBox txtDressPrice;
        private TextBox txtPantsPrice;
        private TextBox txtShirtPrice;
        private Label label9;
        private TextBox txtSubTotalDresses;
        private TextBox txtSubTotalPants;
        private TextBox txtSubTotalShirts;
        private Label label10;
        private Button btnCalculate;
        private Button btnCancel;
        private Button btnExit;
        private GroupBox groupBox3;
        private Label label11;
    }
}
