namespace airplan_tecket
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rpdidCard = new System.Windows.Forms.RadioButton();
            this.rdpPassport = new System.Windows.Forms.RadioButton();
            this.txtDocumentnamber = new System.Windows.Forms.TextBox();
            this.lblDocNo = new System.Windows.Forms.Label();
            this.Dataissue = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateexpiry = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.vtnbook = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "FROM:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(634, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 22);
            this.textBox2.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(328, 140);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(269, 411);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 22);
            this.textBox3.TabIndex = 5;
            // 
            // txtfirstname
            // 
            this.txtfirstname.AutoSize = true;
            this.txtfirstname.Location = new System.Drawing.Point(183, 411);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(80, 17);
            this.txtfirstname.TabIndex = 6;
            this.txtfirstname.Text = "First Name:";
            this.txtfirstname.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(651, 406);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(112, 22);
            this.txtlastname.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Travel Document:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rpdidCard);
            this.groupBox1.Controls.Add(this.rdpPassport);
            this.groupBox1.Location = new System.Drawing.Point(368, 478);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 35);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // rpdidCard
            // 
            this.rpdidCard.AutoSize = true;
            this.rpdidCard.Location = new System.Drawing.Point(112, 14);
            this.rpdidCard.Name = "rpdidCard";
            this.rpdidCard.Size = new System.Drawing.Size(76, 21);
            this.rpdidCard.TabIndex = 1;
            this.rpdidCard.TabStop = true;
            this.rpdidCard.Text = "ID Card";
            this.rpdidCard.UseVisualStyleBackColor = true;
            this.rpdidCard.CheckedChanged += new System.EventHandler(this.RpdidCard_CheckedChanged);
            // 
            // rdpPassport
            // 
            this.rdpPassport.AutoSize = true;
            this.rdpPassport.Location = new System.Drawing.Point(0, 14);
            this.rdpPassport.Name = "rdpPassport";
            this.rdpPassport.Size = new System.Drawing.Size(85, 21);
            this.rdpPassport.TabIndex = 0;
            this.rdpPassport.TabStop = true;
            this.rdpPassport.Text = "Passport";
            this.rdpPassport.UseVisualStyleBackColor = true;
            this.rdpPassport.CheckedChanged += new System.EventHandler(this.RdpPassport_CheckedChanged);
            // 
            // txtDocumentnamber
            // 
            this.txtDocumentnamber.Location = new System.Drawing.Point(680, 491);
            this.txtDocumentnamber.Name = "txtDocumentnamber";
            this.txtDocumentnamber.Size = new System.Drawing.Size(112, 22);
            this.txtDocumentnamber.TabIndex = 12;
            // 
            // lblDocNo
            // 
            this.lblDocNo.AutoSize = true;
            this.lblDocNo.Location = new System.Drawing.Point(576, 494);
            this.lblDocNo.Name = "lblDocNo";
            this.lblDocNo.Size = new System.Drawing.Size(98, 17);
            this.lblDocNo.TabIndex = 11;
            this.lblDocNo.Text = "Document No:";
            // 
            // Dataissue
            // 
            this.Dataissue.AutoSize = true;
            this.Dataissue.Location = new System.Drawing.Point(215, 577);
            this.Dataissue.Name = "Dataissue";
            this.Dataissue.Size = new System.Drawing.Size(147, 17);
            this.Dataissue.TabIndex = 13;
            this.Dataissue.Text = "Document Issue Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(368, 577);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(816, 577);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(206, 22);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // dateexpiry
            // 
            this.dateexpiry.AutoSize = true;
            this.dateexpiry.Location = new System.Drawing.Point(663, 577);
            this.dateexpiry.Name = "dateexpiry";
            this.dateexpiry.Size = new System.Drawing.Size(152, 17);
            this.dateexpiry.TabIndex = 15;
            this.dateexpiry.Text = "Document Expiry Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 655);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "baggage";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(303, 653);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(98, 22);
            this.numericUpDown1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(420, 653);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "kgs";
            // 
            // vtnbook
            // 
            this.vtnbook.Location = new System.Drawing.Point(164, 692);
            this.vtnbook.Name = "vtnbook";
            this.vtnbook.Size = new System.Drawing.Size(731, 32);
            this.vtnbook.TabIndex = 20;
            this.vtnbook.Text = "book(without paying)";
            this.vtnbook.UseVisualStyleBackColor = true;
            this.vtnbook.Click += new System.EventHandler(this.Vtnbook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 725);
            this.Controls.Add(this.vtnbook);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateexpiry);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Dataissue);
            this.Controls.Add(this.txtDocumentnamber);
            this.Controls.Add(this.lblDocNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Flght Booking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rpdidCard;
        private System.Windows.Forms.RadioButton rdpPassport;
        private System.Windows.Forms.TextBox txtDocumentnamber;
        private System.Windows.Forms.Label lblDocNo;
        private System.Windows.Forms.Label Dataissue;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label dateexpiry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button vtnbook;
    }
}

