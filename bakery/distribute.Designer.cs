namespace bakery
{
    partial class distribute
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
            this.distribTime = new System.Windows.Forms.ComboBox();
            this.dGridV1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.monyReceipt = new System.Windows.Forms.TextBox();
            this.monyRemain = new System.Windows.Forms.TextBox();
            this.breadNum = new System.Windows.Forms.TextBox();
            this.distribDate = new System.Windows.Forms.DateTimePicker();
            this.destinations = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.distributionCart = new System.Windows.Forms.ComboBox();
            this.distributor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.totalMony = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.btdelet = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridV1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // distribTime
            // 
            this.distribTime.FormattingEnabled = true;
            this.distribTime.Items.AddRange(new object[] {
            "الفطور",
            "الغداء",
            "العشاء",
            "اخري"});
            this.distribTime.Location = new System.Drawing.Point(561, 147);
            this.distribTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.distribTime.Name = "distribTime";
            this.distribTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.distribTime.Size = new System.Drawing.Size(159, 28);
            this.distribTime.TabIndex = 2;
            this.distribTime.SelectedIndexChanged += new System.EventHandler(this.distribTime_SelectedIndexChanged);
            // 
            // dGridV1
            // 
            this.dGridV1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            this.dGridV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridV1.Location = new System.Drawing.Point(132, 282);
            this.dGridV1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dGridV1.Name = "dGridV1";
            this.dGridV1.Size = new System.Drawing.Size(789, 209);
            this.dGridV1.TabIndex = 14;
            this.dGridV1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGridV1_RowHeaderMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(723, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "الزمن";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(924, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "عدد";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(580, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "التاريخ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(925, 152);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "الجهة";
            // 
            // monyReceipt
            // 
            this.monyReceipt.Location = new System.Drawing.Point(332, 198);
            this.monyReceipt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.monyReceipt.Name = "monyReceipt";
            this.monyReceipt.Size = new System.Drawing.Size(159, 26);
            this.monyReceipt.TabIndex = 7;
            this.monyReceipt.TextChanged += new System.EventHandler(this.monyReceipt_TextChanged);
            this.monyReceipt.Leave += new System.EventHandler(this.monyReceipt_Leave);
            // 
            // monyRemain
            // 
            this.monyRemain.Location = new System.Drawing.Point(128, 198);
            this.monyRemain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.monyRemain.Name = "monyRemain";
            this.monyRemain.Size = new System.Drawing.Size(159, 26);
            this.monyRemain.TabIndex = 8;
            this.monyRemain.TextChanged += new System.EventHandler(this.monyRemain_TextChanged);
            // 
            // breadNum
            // 
            this.breadNum.Location = new System.Drawing.Point(766, 198);
            this.breadNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.breadNum.Name = "breadNum";
            this.breadNum.Size = new System.Drawing.Size(155, 26);
            this.breadNum.TabIndex = 5;
            // 
            // distribDate
            // 
            this.distribDate.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.distribDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.distribDate.Location = new System.Drawing.Point(349, 96);
            this.distribDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.distribDate.Name = "distribDate";
            this.distribDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.distribDate.RightToLeftLayout = true;
            this.distribDate.Size = new System.Drawing.Size(210, 26);
            this.distribDate.TabIndex = 0;
            this.distribDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // destinations
            // 
            this.destinations.FormattingEnabled = true;
            this.destinations.Location = new System.Drawing.Point(762, 147);
            this.destinations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.destinations.Name = "destinations";
            this.destinations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.destinations.Size = new System.Drawing.Size(159, 28);
            this.destinations.TabIndex = 1;
            this.destinations.SelectedIndexChanged += new System.EventHandler(this.destinations_SelectedIndexChanged);
            this.destinations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.destinations_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 84);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::bakery.Properties.Resources._301736710_458694699606932_7145225349708220376_n_fococlipping_standard;
            this.pictureBox2.Location = new System.Drawing.Point(928, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::bakery.Properties.Resources.Truck;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(373, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "التوزيــــــــــــع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(494, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "الموزع";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(288, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "العربة";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(288, 201);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "المتبقي";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(495, 204);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "المبلغ المدفوع";
            // 
            // distributionCart
            // 
            this.distributionCart.FormattingEnabled = true;
            this.distributionCart.Items.AddRange(new object[] {
            "بوكس",
            "توكتوك",
            "ركشة",
            "كارو",
            "اخري"});
            this.distributionCart.Location = new System.Drawing.Point(128, 147);
            this.distributionCart.Name = "distributionCart";
            this.distributionCart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.distributionCart.Size = new System.Drawing.Size(159, 28);
            this.distributionCart.TabIndex = 4;
            // 
            // distributor
            // 
            this.distributor.FormattingEnabled = true;
            this.distributor.Location = new System.Drawing.Point(332, 147);
            this.distributor.Name = "distributor";
            this.distributor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.distributor.Size = new System.Drawing.Size(159, 28);
            this.distributor.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(724, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "المبلغ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // totalMony
            // 
            this.totalMony.Location = new System.Drawing.Point(561, 198);
            this.totalMony.Name = "totalMony";
            this.totalMony.Size = new System.Drawing.Size(159, 26);
            this.totalMony.TabIndex = 6;
            this.totalMony.TextChanged += new System.EventHandler(this.totalMony_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panel2.Location = new System.Drawing.Point(128, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 2);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panel3.Location = new System.Drawing.Point(127, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 2);
            this.panel3.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::bakery.Properties.Resources._015;
            this.button1.Location = new System.Drawing.Point(969, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 34);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btexit
            // 
            this.btexit.Image = global::bakery.Properties.Resources.Delete;
            this.btexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btexit.Location = new System.Drawing.Point(301, 501);
            this.btexit.Name = "btexit";
            this.btexit.Padding = new System.Windows.Forms.Padding(7);
            this.btexit.Size = new System.Drawing.Size(96, 46);
            this.btexit.TabIndex = 12;
            this.btexit.Text = "&خروج";
            this.btexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btdelet
            // 
            this.btdelet.Image = global::bakery.Properties.Resources.Bin_open;
            this.btdelet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdelet.Location = new System.Drawing.Point(426, 501);
            this.btdelet.Name = "btdelet";
            this.btdelet.Padding = new System.Windows.Forms.Padding(7);
            this.btdelet.Size = new System.Drawing.Size(96, 46);
            this.btdelet.TabIndex = 11;
            this.btdelet.Text = "حذ&ف";
            this.btdelet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdelet.UseVisualStyleBackColor = true;
            this.btdelet.Click += new System.EventHandler(this.btdelet_Click);
            // 
            // btupdate
            // 
            this.btupdate.Image = global::bakery.Properties.Resources.arrow_up;
            this.btupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btupdate.Location = new System.Drawing.Point(551, 501);
            this.btupdate.Name = "btupdate";
            this.btupdate.Padding = new System.Windows.Forms.Padding(7);
            this.btupdate.Size = new System.Drawing.Size(96, 46);
            this.btupdate.TabIndex = 10;
            this.btupdate.Text = "تع&ديل";
            this.btupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btsave
            // 
            this.btsave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btsave.Image = global::bakery.Properties.Resources.Save;
            this.btsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsave.Location = new System.Drawing.Point(680, 501);
            this.btsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btsave.Name = "btsave";
            this.btsave.Padding = new System.Windows.Forms.Padding(7);
            this.btsave.Size = new System.Drawing.Size(96, 46);
            this.btsave.TabIndex = 9;
            this.btsave.Text = "&حفظ";
            this.btsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(269, 257);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 27;
            // 
            // distribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 565);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.totalMony);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btdelet);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.distributor);
            this.Controls.Add(this.distributionCart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.breadNum);
            this.Controls.Add(this.monyRemain);
            this.Controls.Add(this.monyReceipt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dGridV1);
            this.Controls.Add(this.destinations);
            this.Controls.Add(this.distribTime);
            this.Controls.Add(this.distribDate);
            this.Controls.Add(this.btsave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "distribute";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "distribute";
            this.Load += new System.EventHandler(this.distribute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridV1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.ComboBox distribTime;
        private System.Windows.Forms.DataGridView dGridV1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox monyReceipt;
        private System.Windows.Forms.TextBox monyRemain;
        private System.Windows.Forms.TextBox breadNum;
        private System.Windows.Forms.DateTimePicker distribDate;
        private System.Windows.Forms.ComboBox destinations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox distributionCart;
        private System.Windows.Forms.ComboBox distributor;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelet;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox totalMony;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMessage;
    }
}