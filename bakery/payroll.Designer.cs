namespace bakery
{
    partial class payroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payroll));
            this.bsave = new System.Windows.Forms.Button();
            this.bupdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.empName = new System.Windows.Forms.ComboBox();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.paydate = new System.Windows.Forms.DateTimePicker();
            this.memos = new System.Windows.Forms.TextBox();
            this.payAmount = new System.Windows.Forms.TextBox();
            this.monyPaid = new System.Windows.Forms.TextBox();
            this.monyLeft = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empId = new System.Windows.Forms.TextBox();
            this.wrdia = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsave
            // 
            this.bsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.bsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsave.ForeColor = System.Drawing.Color.Black;
            this.bsave.Image = global::bakery.Properties.Resources.Save;
            this.bsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bsave.Location = new System.Drawing.Point(560, 471);
            this.bsave.Name = "bsave";
            this.bsave.Padding = new System.Windows.Forms.Padding(10);
            this.bsave.Size = new System.Drawing.Size(100, 55);
            this.bsave.TabIndex = 4;
            this.bsave.Text = "حف&ظ";
            this.bsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bsave.UseVisualStyleBackColor = false;
            this.bsave.Click += new System.EventHandler(this.bsave_Click);
            // 
            // bupdate
            // 
            this.bupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.bupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bupdate.ForeColor = System.Drawing.Color.Black;
            this.bupdate.Image = global::bakery.Properties.Resources.arrow_up;
            this.bupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bupdate.Location = new System.Drawing.Point(437, 471);
            this.bupdate.Name = "bupdate";
            this.bupdate.Padding = new System.Windows.Forms.Padding(10);
            this.bupdate.Size = new System.Drawing.Size(100, 55);
            this.bupdate.TabIndex = 5;
            this.bupdate.Text = "تع&ديل";
            this.bupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bupdate.UseVisualStyleBackColor = false;
            this.bupdate.Click += new System.EventHandler(this.bupdate_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.ForeColor = System.Drawing.Color.Black;
            this.bDelete.Image = global::bakery.Properties.Resources.Bin_open;
            this.bDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDelete.Location = new System.Drawing.Point(319, 471);
            this.bDelete.Name = "bDelete";
            this.bDelete.Padding = new System.Windows.Forms.Padding(10);
            this.bDelete.Size = new System.Drawing.Size(100, 55);
            this.bDelete.TabIndex = 6;
            this.bDelete.Text = "&حذف";
            this.bDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::bakery.Properties.Resources.Delete;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(190, 471);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10);
            this.button4.Size = new System.Drawing.Size(100, 55);
            this.button4.TabIndex = 7;
            this.button4.Text = "&خروج";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // empName
            // 
            this.empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.empName.FormattingEnabled = true;
            this.empName.Location = new System.Drawing.Point(359, 114);
            this.empName.Name = "empName";
            this.empName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empName.Size = new System.Drawing.Size(261, 28);
            this.empName.TabIndex = 1;
            this.empName.SelectedIndexChanged += new System.EventHandler(this.empName_SelectedIndexChanged);
            this.empName.SelectedValueChanged += new System.EventHandler(this.empName_SelectedValueChanged);
            // 
            // dGV1
            // 
            this.dGV1.BackgroundColor = System.Drawing.Color.White;
            this.dGV1.GridColor = System.Drawing.Color.Black;
            this.dGV1.Location = new System.Drawing.Point(90, 339);
            this.dGV1.Name = "dGV1";
            this.dGV1.Size = new System.Drawing.Size(597, 105);
            this.dGV1.TabIndex = 8;
            this.dGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellContentClick);
            this.dGV1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV1_RowHeaderMouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(496, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 27);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // paydate
            // 
            this.paydate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.paydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.paydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.paydate.Location = new System.Drawing.Point(496, 78);
            this.paydate.Name = "paydate";
            this.paydate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paydate.RightToLeftLayout = true;
            this.paydate.Size = new System.Drawing.Size(124, 27);
            this.paydate.TabIndex = 0;
            this.paydate.ValueChanged += new System.EventHandler(this.paydate_ValueChanged);
            // 
            // memos
            // 
            this.memos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.memos.Location = new System.Drawing.Point(359, 288);
            this.memos.Name = "memos";
            this.memos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.memos.Size = new System.Drawing.Size(261, 27);
            this.memos.TabIndex = 3;
            // 
            // payAmount
            // 
            this.payAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.payAmount.Location = new System.Drawing.Point(269, 38);
            this.payAmount.Name = "payAmount";
            this.payAmount.Size = new System.Drawing.Size(100, 27);
            this.payAmount.TabIndex = 0;
            this.payAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monyPaid
            // 
            this.monyPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.monyPaid.Location = new System.Drawing.Point(145, 38);
            this.monyPaid.Name = "monyPaid";
            this.monyPaid.Size = new System.Drawing.Size(100, 27);
            this.monyPaid.TabIndex = 1;
            this.monyPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.monyPaid.TextChanged += new System.EventHandler(this.monyPaid_TextChanged);
            // 
            // monyLeft
            // 
            this.monyLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.monyLeft.Location = new System.Drawing.Point(21, 38);
            this.monyLeft.Name = "monyLeft";
            this.monyLeft.Size = new System.Drawing.Size(100, 27);
            this.monyLeft.TabIndex = 2;
            this.monyLeft.Text = "0";
            this.monyLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.monyLeft.TextChanged += new System.EventHandler(this.monyLeft_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(626, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "اليوم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(626, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "الاسم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Location = new System.Drawing.Point(163, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "الوردية";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Location = new System.Drawing.Point(564, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "العمل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Location = new System.Drawing.Point(626, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "ملاحظات";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label7.Location = new System.Drawing.Point(63, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "المتبقي";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label8.Location = new System.Drawing.Point(181, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "المستلم";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label9.Location = new System.Drawing.Point(297, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "المستحق";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(175)))), ((int)(((byte)(177)))));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.payAmount);
            this.groupBox1.Controls.Add(this.monyPaid);
            this.groupBox1.Controls.Add(this.monyLeft);
            this.groupBox1.Location = new System.Drawing.Point(252, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 56);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(175)))), ((int)(((byte)(177)))));
            this.label10.Location = new System.Drawing.Point(269, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 33);
            this.label10.TabIndex = 0;
            this.label10.Text = "يوميات العمال";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(266, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "يوميات العمال";
            // 
            // empId
            // 
            this.empId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(170)))), ((int)(((byte)(177)))));
            this.empId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.empId.Location = new System.Drawing.Point(273, 115);
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(83, 24);
            this.empId.TabIndex = 21;
            this.empId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wrdia
            // 
            this.wrdia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrdia.FormattingEnabled = true;
            this.wrdia.Items.AddRange(new object[] {
            "الاولي",
            "الثانية",
            "الثالثة",
            "الرابعة"});
            this.wrdia.Location = new System.Drawing.Point(23, 126);
            this.wrdia.Name = "wrdia";
            this.wrdia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wrdia.Size = new System.Drawing.Size(121, 28);
            this.wrdia.TabIndex = 22;
            this.wrdia.Text = "الاولي";
            this.wrdia.SelectedIndexChanged += new System.EventHandler(this.wrdia_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(155, 524);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(17, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(184, 93);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الوردية";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(112, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "عدد الارغفة";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(112, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "عدد الشولات";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.textBox4.Location = new System.Drawing.Point(359, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 27);
            this.textBox4.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label14.Location = new System.Drawing.Point(394, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "الاستحقاق";
            // 
            // payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(175)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(750, 572);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.wrdia);
            this.Controls.Add(this.empId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memos);
            this.Controls.Add(this.paydate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bupdate);
            this.Controls.Add(this.bsave);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 572);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(678, 572);
            this.Name = "payroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "payroll";
            this.Load += new System.EventHandler(this.payroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bsave;
        private System.Windows.Forms.Button bupdate;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox empName;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker paydate;
        private System.Windows.Forms.TextBox memos;
        private System.Windows.Forms.TextBox payAmount;
        private System.Windows.Forms.TextBox monyPaid;
        private System.Windows.Forms.TextBox monyLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox empId;
        private System.Windows.Forms.ComboBox wrdia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label14;
    }
}