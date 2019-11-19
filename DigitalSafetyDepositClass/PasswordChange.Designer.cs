namespace DigitalSafetyDepositClass
{
    partial class PasswordChange
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
            this.CurrentPassTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReenterPassTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newPassTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SupportBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentPassTextbox
            // 
            this.CurrentPassTextbox.Location = new System.Drawing.Point(214, 175);
            this.CurrentPassTextbox.Name = "CurrentPassTextbox";
            this.CurrentPassTextbox.PasswordChar = '0';
            this.CurrentPassTextbox.Size = new System.Drawing.Size(357, 20);
            this.CurrentPassTextbox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Current password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "user_name";
            // 
            // ReenterPassTextBox
            // 
            this.ReenterPassTextBox.Location = new System.Drawing.Point(214, 280);
            this.ReenterPassTextBox.Name = "ReenterPassTextBox";
            this.ReenterPassTextBox.PasswordChar = '0';
            this.ReenterPassTextBox.Size = new System.Drawing.Size(357, 20);
            this.ReenterPassTextBox.TabIndex = 25;
            this.ReenterPassTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Re-enter password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Location = new System.Drawing.Point(214, 226);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.PasswordChar = '0';
            this.newPassTextBox.Size = new System.Drawing.Size(357, 20);
            this.newPassTextBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "New password";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 28);
            this.button3.TabIndex = 29;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(294, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 28);
            this.button2.TabIndex = 28;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(464, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '0';
            this.textBox4.Size = new System.Drawing.Size(107, 20);
            this.textBox4.TabIndex = 30;
            // 
            // SupportBt
            // 
            this.SupportBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupportBt.ForeColor = System.Drawing.Color.Black;
            this.SupportBt.Location = new System.Drawing.Point(555, 47);
            this.SupportBt.Margin = new System.Windows.Forms.Padding(2);
            this.SupportBt.Name = "SupportBt";
            this.SupportBt.Size = new System.Drawing.Size(34, 37);
            this.SupportBt.TabIndex = 31;
            this.SupportBt.Text = "?";
            this.SupportBt.UseVisualStyleBackColor = true;
            this.SupportBt.Click += new System.EventHandler(this.SupportBt_Click);
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 414);
            this.Controls.Add(this.SupportBt);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.newPassTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReenterPassTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentPassTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "PasswordChange";
            this.Text = "PasswordChange";
            this.Load += new System.EventHandler(this.PasswordChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CurrentPassTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReenterPassTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button SupportBt;
    }
}