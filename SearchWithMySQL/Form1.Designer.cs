namespace SearchWithMySQL
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textLandLine = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textCellNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textDebt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textDateOfBirth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(40, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 104);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 63);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(266, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "MySQL connection in C#";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(40, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 592);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(625, 114);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 465);
            this.panel5.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.Location = new System.Drawing.Point(25, 361);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(212, 55);
            this.button6.TabIndex = 5;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.Location = new System.Drawing.Point(25, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(212, 55);
            this.button5.TabIndex = 4;
            this.button5.Text = "Print";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Location = new System.Drawing.Point(25, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(25, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(25, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(25, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Add_NewClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.textAddress);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.textEmail);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.textLandLine);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.textCellNumber);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textDebt);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textDateOfBirth);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textAge);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textLastName);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textFirstName);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textId);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(13, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(606, 559);
            this.panel4.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 432);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(571, 114);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(179, 390);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(276, 23);
            this.textAddress.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(124, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Debt:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(179, 350);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(276, 23);
            this.textEmail.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Address:";
            // 
            // textLandLine
            // 
            this.textLandLine.Location = new System.Drawing.Point(179, 311);
            this.textLandLine.Name = "textLandLine";
            this.textLandLine.Size = new System.Drawing.Size(276, 23);
            this.textLandLine.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Email:";
            // 
            // textCellNumber
            // 
            this.textCellNumber.Location = new System.Drawing.Point(179, 272);
            this.textCellNumber.Name = "textCellNumber";
            this.textCellNumber.Size = new System.Drawing.Size(276, 23);
            this.textCellNumber.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Land line:";
            // 
            // textDebt
            // 
            this.textDebt.Location = new System.Drawing.Point(179, 231);
            this.textDebt.Name = "textDebt";
            this.textDebt.Size = new System.Drawing.Size(276, 23);
            this.textDebt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cell number:";
            // 
            // textDateOfBirth
            // 
            this.textDateOfBirth.Location = new System.Drawing.Point(179, 189);
            this.textDateOfBirth.Name = "textDateOfBirth";
            this.textDateOfBirth.Size = new System.Drawing.Size(276, 23);
            this.textDateOfBirth.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date of birth:";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(179, 150);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(276, 23);
            this.textAge.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Age:";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(179, 111);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(276, 23);
            this.textLastName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name:";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(179, 73);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(276, 23);
            this.textFirstName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(179, 34);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(276, 23);
            this.textId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.textBox11);
            this.panel6.Location = new System.Drawing.Point(665, 184);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(265, 88);
            this.panel6.TabIndex = 3;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(25, 19);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(212, 52);
            this.textBox11.TabIndex = 4;
            this.textBox11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox11_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 768);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel5;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel4;
        private TextBox textAddress;
        private Label label11;
        private TextBox textEmail;
        private Label label10;
        private TextBox textLandLine;
        private Label label9;
        private TextBox textCellNumber;
        private Label label8;
        private TextBox textDebt;
        private Label label7;
        private TextBox textDateOfBirth;
        private Label label6;
        private TextBox textAge;
        private Label label5;
        private TextBox textLastName;
        private Label label4;
        private TextBox textFirstName;
        private Label label3;
        private TextBox textId;
        private Label label2;
        private Panel panel6;
        private DataGridView dataGridView1;
        private TextBox textBox11;
    }
}