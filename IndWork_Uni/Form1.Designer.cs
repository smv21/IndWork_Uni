namespace IndWork_Uni
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
            this.label_info = new System.Windows.Forms.Label();
            this.textBox_cardnumber = new System.Windows.Forms.TextBox();
            this.button_checknumber = new System.Windows.Forms.Button();
            this.label_pincodeinfo = new System.Windows.Forms.Label();
            this.label_counter = new System.Windows.Forms.Label();
            this.textBox_pincode = new System.Windows.Forms.TextBox();
            this.button_checkpincode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_cash = new System.Windows.Forms.Button();
            this.button_money = new System.Windows.Forms.Button();
            this.button_payment = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_display = new System.Windows.Forms.Label();
            this.button_sum = new System.Windows.Forms.Button();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.label_sum = new System.Windows.Forms.Label();
            this.button_reportmoney = new System.Windows.Forms.Button();
            this.label_report = new System.Windows.Forms.Label();
            this.checkBox_report = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(12, 8);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(125, 15);
            this.label_info.TabIndex = 0;
            this.label_info.Text = "Введите номер карты";
            // 
            // textBox_cardnumber
            // 
            this.textBox_cardnumber.Location = new System.Drawing.Point(12, 26);
            this.textBox_cardnumber.Name = "textBox_cardnumber";
            this.textBox_cardnumber.Size = new System.Drawing.Size(271, 23);
            this.textBox_cardnumber.TabIndex = 1;
            // 
            // button_checknumber
            // 
            this.button_checknumber.Location = new System.Drawing.Point(12, 55);
            this.button_checknumber.Name = "button_checknumber";
            this.button_checknumber.Size = new System.Drawing.Size(271, 23);
            this.button_checknumber.TabIndex = 2;
            this.button_checknumber.Text = "Ввод карты";
            this.button_checknumber.UseVisualStyleBackColor = true;
            this.button_checknumber.Click += new System.EventHandler(this.button_checknumber_Click);
            // 
            // label_pincodeinfo
            // 
            this.label_pincodeinfo.AutoSize = true;
            this.label_pincodeinfo.Location = new System.Drawing.Point(12, 94);
            this.label_pincodeinfo.Name = "label_pincodeinfo";
            this.label_pincodeinfo.Size = new System.Drawing.Size(0, 15);
            this.label_pincodeinfo.TabIndex = 3;
            // 
            // label_counter
            // 
            this.label_counter.AutoSize = true;
            this.label_counter.Location = new System.Drawing.Point(141, 94);
            this.label_counter.Name = "label_counter";
            this.label_counter.Size = new System.Drawing.Size(0, 15);
            this.label_counter.TabIndex = 4;
            // 
            // textBox_pincode
            // 
            this.textBox_pincode.Location = new System.Drawing.Point(12, 112);
            this.textBox_pincode.Name = "textBox_pincode";
            this.textBox_pincode.Size = new System.Drawing.Size(151, 23);
            this.textBox_pincode.TabIndex = 5;
            // 
            // button_checkpincode
            // 
            this.button_checkpincode.Location = new System.Drawing.Point(169, 112);
            this.button_checkpincode.Name = "button_checkpincode";
            this.button_checkpincode.Size = new System.Drawing.Size(113, 23);
            this.button_checkpincode.TabIndex = 6;
            this.button_checkpincode.Text = "Ввести пин";
            this.button_checkpincode.UseVisualStyleBackColor = true;
            this.button_checkpincode.Click += new System.EventHandler(this.button_checkpincode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Операции:";
            // 
            // button_cash
            // 
            this.button_cash.Enabled = false;
            this.button_cash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_cash.Location = new System.Drawing.Point(13, 214);
            this.button_cash.Name = "button_cash";
            this.button_cash.Size = new System.Drawing.Size(85, 57);
            this.button_cash.TabIndex = 8;
            this.button_cash.Text = "Снять наличные";
            this.button_cash.UseVisualStyleBackColor = true;
            this.button_cash.Click += new System.EventHandler(this.button_cash_Click);
            // 
            // button_money
            // 
            this.button_money.Enabled = false;
            this.button_money.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_money.Location = new System.Drawing.Point(104, 214);
            this.button_money.Name = "button_money";
            this.button_money.Size = new System.Drawing.Size(91, 57);
            this.button_money.TabIndex = 9;
            this.button_money.Text = "Узнать остаток на счету";
            this.button_money.UseVisualStyleBackColor = true;
            this.button_money.Click += new System.EventHandler(this.button_money_Click);
            // 
            // button_payment
            // 
            this.button_payment.Enabled = false;
            this.button_payment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_payment.Location = new System.Drawing.Point(201, 214);
            this.button_payment.Name = "button_payment";
            this.button_payment.Size = new System.Drawing.Size(82, 57);
            this.button_payment.TabIndex = 10;
            this.button_payment.Text = "Безналичный платеж";
            this.button_payment.UseVisualStyleBackColor = true;
            this.button_payment.Click += new System.EventHandler(this.button_payment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(13, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 33);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label_display
            // 
            this.label_display.AutoSize = true;
            this.label_display.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_display.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_display.Location = new System.Drawing.Point(27, 161);
            this.label_display.Name = "label_display";
            this.label_display.Size = new System.Drawing.Size(0, 15);
            this.label_display.TabIndex = 14;
            // 
            // button_sum
            // 
            this.button_sum.Enabled = false;
            this.button_sum.Location = new System.Drawing.Point(168, 386);
            this.button_sum.Name = "button_sum";
            this.button_sum.Size = new System.Drawing.Size(114, 23);
            this.button_sum.TabIndex = 15;
            this.button_sum.Text = "Ввести сумму";
            this.button_sum.UseVisualStyleBackColor = true;
            this.button_sum.Click += new System.EventHandler(this.button_sum_Click);
            // 
            // textBox_sum
            // 
            this.textBox_sum.Enabled = false;
            this.textBox_sum.Location = new System.Drawing.Point(12, 387);
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.Size = new System.Drawing.Size(151, 23);
            this.textBox_sum.TabIndex = 16;
            // 
            // label_sum
            // 
            this.label_sum.AutoSize = true;
            this.label_sum.Location = new System.Drawing.Point(12, 366);
            this.label_sum.Name = "label_sum";
            this.label_sum.Size = new System.Drawing.Size(122, 15);
            this.label_sum.TabIndex = 17;
            this.label_sum.Text = "Введите сумму денег";
            // 
            // button_reportmoney
            // 
            this.button_reportmoney.Enabled = false;
            this.button_reportmoney.Location = new System.Drawing.Point(113, 277);
            this.button_reportmoney.Name = "button_reportmoney";
            this.button_reportmoney.Size = new System.Drawing.Size(170, 48);
            this.button_reportmoney.TabIndex = 18;
            this.button_reportmoney.Text = "Напечатать справку по остатку на счету";
            this.button_reportmoney.UseVisualStyleBackColor = true;
            this.button_reportmoney.Click += new System.EventHandler(this.button_reportmoney_Click);
            // 
            // label_report
            // 
            this.label_report.AutoSize = true;
            this.label_report.Location = new System.Drawing.Point(13, 453);
            this.label_report.Name = "label_report";
            this.label_report.Size = new System.Drawing.Size(0, 15);
            this.label_report.TabIndex = 19;
            // 
            // checkBox_report
            // 
            this.checkBox_report.AutoSize = true;
            this.checkBox_report.Location = new System.Drawing.Point(12, 334);
            this.checkBox_report.Name = "checkBox_report";
            this.checkBox_report.Size = new System.Drawing.Size(256, 19);
            this.checkBox_report.TabIndex = 20;
            this.checkBox_report.Text = "Напечатать справку по снятию наличных";
            this.checkBox_report.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 554);
            this.Controls.Add(this.checkBox_report);
            this.Controls.Add(this.label_report);
            this.Controls.Add(this.button_reportmoney);
            this.Controls.Add(this.label_sum);
            this.Controls.Add(this.textBox_sum);
            this.Controls.Add(this.button_sum);
            this.Controls.Add(this.label_display);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_payment);
            this.Controls.Add(this.button_money);
            this.Controls.Add(this.button_cash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_checkpincode);
            this.Controls.Add(this.textBox_pincode);
            this.Controls.Add(this.label_counter);
            this.Controls.Add(this.label_pincodeinfo);
            this.Controls.Add(this.button_checknumber);
            this.Controls.Add(this.textBox_cardnumber);
            this.Controls.Add(this.label_info);
            this.Name = "Form1";
            this.Text = "Банкомат";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.TextBox textBox_cardnumber;
        private System.Windows.Forms.Button button_checknumber;
        private System.Windows.Forms.Label label_pincodeinfo;
        private System.Windows.Forms.Label label_counter;
        private System.Windows.Forms.TextBox textBox_pincode;
        private System.Windows.Forms.Button button_checkpincode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_cash;
        private System.Windows.Forms.Button button_money;
        private System.Windows.Forms.Button button_payment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_display;
        private System.Windows.Forms.Button button_sum;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.Label label_sum;
        private System.Windows.Forms.Button button_reportmoney;
        private System.Windows.Forms.Label label_report;
        private System.Windows.Forms.CheckBox checkBox_report;
    }
}