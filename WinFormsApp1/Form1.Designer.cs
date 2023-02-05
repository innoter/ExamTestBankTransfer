namespace WinFormsApp1
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
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtBoxAccountName = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.numericUpDownDeposite = new System.Windows.Forms.NumericUpDown();
            this.buttonDeposite = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTransfer = new System.Windows.Forms.ComboBox();
            this.numericUpDownTransfer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelAmountTransfer = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelIBAN = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeposite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransfer)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Transfer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Put money on accounts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(492, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Register";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(351, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(8, 8);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtBoxAccountName
            // 
            this.txtBoxAccountName.Location = new System.Drawing.Point(150, 70);
            this.txtBoxAccountName.Name = "txtBoxAccountName";
            this.txtBoxAccountName.Size = new System.Drawing.Size(279, 23);
            this.txtBoxAccountName.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "AccountName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(226, 199);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "IBAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "AccountName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Deposit";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(150, 38);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(417, 23);
            this.txtIBAN.TabIndex = 16;
            // 
            // numericUpDownDeposite
            // 
            this.numericUpDownDeposite.Location = new System.Drawing.Point(228, 228);
            this.numericUpDownDeposite.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numericUpDownDeposite.Name = "numericUpDownDeposite";
            this.numericUpDownDeposite.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownDeposite.TabIndex = 18;
            // 
            // buttonDeposite
            // 
            this.buttonDeposite.Location = new System.Drawing.Point(492, 228);
            this.buttonDeposite.Name = "buttonDeposite";
            this.buttonDeposite.Size = new System.Drawing.Size(75, 23);
            this.buttonDeposite.TabIndex = 19;
            this.buttonDeposite.Text = "Deposit";
            this.buttonDeposite.UseVisualStyleBackColor = true;
            this.buttonDeposite.Click += new System.EventHandler(this.buttonDeposite_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "fee 0.1%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Current Customer Account";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Balance";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(137, 268);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(0, 15);
            this.labelBalance.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "select account to transfer money";
            // 
            // comboBoxTransfer
            // 
            this.comboBoxTransfer.DisplayMember = "AccountName";
            this.comboBoxTransfer.FormattingEnabled = true;
            this.comboBoxTransfer.Location = new System.Drawing.Point(271, 380);
            this.comboBoxTransfer.Name = "comboBoxTransfer";
            this.comboBoxTransfer.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTransfer.TabIndex = 25;
            this.comboBoxTransfer.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransfer_SelectedIndexChanged);
            // 
            // numericUpDownTransfer
            // 
            this.numericUpDownTransfer.Location = new System.Drawing.Point(202, 419);
            this.numericUpDownTransfer.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numericUpDownTransfer.Name = "numericUpDownTransfer";
            this.numericUpDownTransfer.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownTransfer.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "TotalTaxFromCustomer :";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(202, 493);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(0, 15);
            this.labelTax.TabIndex = 29;
            // 
            // labelAmountTransfer
            // 
            this.labelAmountTransfer.AutoSize = true;
            this.labelAmountTransfer.Location = new System.Drawing.Point(122, 467);
            this.labelAmountTransfer.Name = "labelAmountTransfer";
            this.labelAmountTransfer.Size = new System.Drawing.Size(0, 15);
            this.labelAmountTransfer.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 464);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "Balance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "Create account for customers";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "Put money on accounts";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(60, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 15);
            this.label13.TabIndex = 34;
            this.label13.Text = "Transfer money";
            // 
            // labelIBAN
            // 
            this.labelIBAN.AutoSize = true;
            this.labelIBAN.Location = new System.Drawing.Point(399, 199);
            this.labelIBAN.Name = "labelIBAN";
            this.labelIBAN.Size = new System.Drawing.Size(0, 15);
            this.labelIBAN.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(355, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 15);
            this.label14.TabIndex = 36;
            this.label14.Text = "IBAN : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelIBAN);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelAmountTransfer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownTransfer);
            this.Controls.Add(this.comboBoxTransfer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonDeposite);
            this.Controls.Add(this.numericUpDownDeposite);
            this.Controls.Add(this.txtIBAN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtBoxAccountName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeposite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransfer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button3;
        private Label label1;
        private TextBox txtBoxAccountName;
        private Button button4;
        private Button button5;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIBAN;
        private NumericUpDown numericUpDownDeposite;
        private Button button6;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelBalance;
        private Label label9;
        private ComboBox comboBoxTransfer;
        private NumericUpDown numericUpDownTransfer;
        private Label label2;
        private Label labelTax;
        private Label labelAmountTransfer;
        private Label label11;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label labelIBAN;
        private Label label14;
        private Button buttonDeposite;
    }
}