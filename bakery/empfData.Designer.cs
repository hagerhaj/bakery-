namespace bakery
{
    partial class empfData
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
            this.empJop = new System.Windows.Forms.ComboBox();
            this.empHirdate = new System.Windows.Forms.DateTimePicker();
            this.empHealth = new System.Windows.Forms.TextBox();
            this.empName = new System.Windows.Forms.TextBox();
            this.empId = new System.Windows.Forms.TextBox();
            this.empAddress = new System.Windows.Forms.TextBox();
            this.empTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btsave = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelet = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.releventTel = new System.Windows.Forms.TextBox();
            this.natonalNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // empJop
            // 
            this.empJop.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empJop.FormattingEnabled = true;
            this.empJop.Items.AddRange(new object[] {
            "عجان",
            "فرام",
            "طولجي",
            "بنكجي"});
            this.empJop.Location = new System.Drawing.Point(17, 57);
            this.empJop.Name = "empJop";
            this.empJop.Size = new System.Drawing.Size(254, 34);
            this.empJop.TabIndex = 3;
            // 
            // empHirdate
            // 
            this.empHirdate.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empHirdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.empHirdate.Location = new System.Drawing.Point(17, 20);
            this.empHirdate.Name = "empHirdate";
            this.empHirdate.Size = new System.Drawing.Size(254, 32);
            this.empHirdate.TabIndex = 1;
            // 
            // empHealth
            // 
            this.empHealth.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empHealth.Location = new System.Drawing.Point(415, 309);
            this.empHealth.Name = "empHealth";
            this.empHealth.Size = new System.Drawing.Size(254, 32);
            this.empHealth.TabIndex = 6;
            // 
            // empName
            // 
            this.empName.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.Location = new System.Drawing.Point(348, 25);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(254, 32);
            this.empName.TabIndex = 0;
            this.empName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // empId
            // 
            this.empId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empId.Location = new System.Drawing.Point(567, 125);
            this.empId.Name = "empId";
            this.empId.ReadOnly = true;
            this.empId.Size = new System.Drawing.Size(100, 22);
            this.empId.TabIndex = 21;
            // 
            // empAddress
            // 
            this.empAddress.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empAddress.Location = new System.Drawing.Point(348, 63);
            this.empAddress.Name = "empAddress";
            this.empAddress.Size = new System.Drawing.Size(254, 32);
            this.empAddress.TabIndex = 2;
            // 
            // empTel
            // 
            this.empTel.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empTel.Location = new System.Drawing.Point(17, 96);
            this.empTel.Name = "empTel";
            this.empTel.Size = new System.Drawing.Size(254, 32);
            this.empTel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(672, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "العنوان الحالي";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "تاريخ التعيين";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(673, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "الاســــــــــم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(673, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "الرقم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "نوع العمل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(675, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "الحالة الصحية";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(345, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "الهاتف";
            // 
            // btsave
            // 
            this.btsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(73)))));
            this.btsave.ForeColor = System.Drawing.Color.White;
            this.btsave.Location = new System.Drawing.Point(547, 600);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(122, 48);
            this.btsave.TabIndex = 8;
            this.btsave.Text = "اضافة";
            this.btsave.UseVisualStyleBackColor = false;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btupdate
            // 
            this.btupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(73)))));
            this.btupdate.ForeColor = System.Drawing.Color.White;
            this.btupdate.Location = new System.Drawing.Point(414, 600);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(122, 48);
            this.btupdate.TabIndex = 9;
            this.btupdate.Text = "تعديل";
            this.btupdate.UseVisualStyleBackColor = false;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btdelet
            // 
            this.btdelet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(73)))));
            this.btdelet.ForeColor = System.Drawing.Color.White;
            this.btdelet.Location = new System.Drawing.Point(281, 600);
            this.btdelet.Name = "btdelet";
            this.btdelet.Size = new System.Drawing.Size(122, 48);
            this.btdelet.TabIndex = 10;
            this.btdelet.Text = "حذف";
            this.btdelet.UseVisualStyleBackColor = false;
            this.btdelet.Click += new System.EventHandler(this.btdelet_Click);
            // 
            // btexit
            // 
            this.btexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(73)))));
            this.btexit.ForeColor = System.Drawing.Color.White;
            this.btexit.Location = new System.Drawing.Point(148, 600);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(122, 48);
            this.btexit.TabIndex = 11;
            this.btexit.Text = "خروج";
            this.btexit.UseVisualStyleBackColor = false;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // dgvEmp
            // 
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.GridColor = System.Drawing.Color.AliceBlue;
            this.dgvEmp.Location = new System.Drawing.Point(64, 401);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.Size = new System.Drawing.Size(690, 193);
            this.dgvEmp.TabIndex = 10;
            this.dgvEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellContentClick);
            this.dgvEmp.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmp_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 82);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(358, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "العمــــــــــــــــال";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.releventTel);
            this.groupBox1.Controls.Add(this.natonalNo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.empHirdate);
            this.groupBox1.Controls.Add(this.empJop);
            this.groupBox1.Controls.Add(this.empTel);
            this.groupBox1.Controls.Add(this.empName);
            this.groupBox1.Controls.Add(this.empAddress);
            this.groupBox1.Location = new System.Drawing.Point(67, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 187);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // releventTel
            // 
            this.releventTel.Font = new System.Drawing.Font("Simplified Arabic", 11.25F);
            this.releventTel.Location = new System.Drawing.Point(17, 133);
            this.releventTel.Name = "releventTel";
            this.releventTel.Size = new System.Drawing.Size(254, 32);
            this.releventTel.TabIndex = 7;
            // 
            // natonalNo
            // 
            this.natonalNo.Font = new System.Drawing.Font("Simplified Arabic", 11.25F);
            this.natonalNo.Location = new System.Drawing.Point(348, 101);
            this.natonalNo.Name = "natonalNo";
            this.natonalNo.Size = new System.Drawing.Size(254, 32);
            this.natonalNo.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(606, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 18);
            this.label12.TabIndex = 13;
            this.label12.Text = "الرقم الوطني";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(273, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "هاتف احد الاقارب";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(73)))));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(73)))));
            this.label9.Location = new System.Drawing.Point(58, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 65);
            this.label9.TabIndex = 18;
            this.label9.Text = "-";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(73)))));
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(73)))));
            this.label10.Location = new System.Drawing.Point(715, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 65);
            this.label10.TabIndex = 19;
            this.label10.Text = "-";
            this.label10.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(73)))));
            this.label11.Location = new System.Drawing.Point(98, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "label11";
            // 
            // empfData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(821, 669);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btdelet);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empId);
            this.Controls.Add(this.empHealth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "empfData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العمال";
            this.Load += new System.EventHandler(this.empfData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox empJop;
        private System.Windows.Forms.DateTimePicker empHirdate;
        private System.Windows.Forms.TextBox empHealth;
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.TextBox empId;
        private System.Windows.Forms.TextBox empAddress;
        private System.Windows.Forms.TextBox empTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelet;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox releventTel;
        private System.Windows.Forms.TextBox natonalNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}