namespace Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_4 = new System.Windows.Forms.Button();
            this.textboxdisplay = new System.Windows.Forms.TextBox();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_12 = new System.Windows.Forms.Button();
            this.btn_16 = new System.Windows.Forms.Button();
            this.btn_20 = new System.Windows.Forms.Button();
            this.btn_24 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_11 = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_15 = new System.Windows.Forms.Button();
            this.btn_14 = new System.Windows.Forms.Button();
            this.btn_13 = new System.Windows.Forms.Button();
            this.btn_19 = new System.Windows.Forms.Button();
            this.btn_18 = new System.Windows.Forms.Button();
            this.btn_17 = new System.Windows.Forms.Button();
            this.btn_23 = new System.Windows.Forms.Button();
            this.btn_22 = new System.Windows.Forms.Button();
            this.btn_21 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(283, 387);
            this.btn_4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(81, 55);
            this.btn_4.TabIndex = 0;
            this.btn_4.Text = "=";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxdisplay
            // 
            this.textboxdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxdisplay.Location = new System.Drawing.Point(11, 30);
            this.textboxdisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxdisplay.MaxLength = 1;
            this.textboxdisplay.Name = "textboxdisplay";
            this.textboxdisplay.ReadOnly = true;
            this.textboxdisplay.Size = new System.Drawing.Size(351, 29);
            this.textboxdisplay.TabIndex = 1;
            this.textboxdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textboxdisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textboxdisplay.Validating += new System.ComponentModel.CancelEventHandler(this.textboxdisplay_Validating);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(283, 323);
            this.btn_8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(81, 60);
            this.btn_8.TabIndex = 2;
            this.btn_8.Text = "+";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(193, 387);
            this.btn_3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(86, 55);
            this.btn_3.TabIndex = 3;
            this.btn_3.Text = ",";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(103, 387);
            this.btn_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(85, 55);
            this.btn_2.TabIndex = 4;
            this.btn_2.Text = "0";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(11, 387);
            this.btn_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(89, 55);
            this.btn_1.TabIndex = 5;
            this.btn_1.Text = "+/-";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_12
            // 
            this.btn_12.Location = new System.Drawing.Point(284, 259);
            this.btn_12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_12.Name = "btn_12";
            this.btn_12.Size = new System.Drawing.Size(81, 60);
            this.btn_12.TabIndex = 6;
            this.btn_12.Text = "-";
            this.btn_12.UseVisualStyleBackColor = true;
            this.btn_12.Click += new System.EventHandler(this.btn_12_Click);
            // 
            // btn_16
            // 
            this.btn_16.Location = new System.Drawing.Point(284, 193);
            this.btn_16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_16.Name = "btn_16";
            this.btn_16.Size = new System.Drawing.Size(81, 62);
            this.btn_16.TabIndex = 7;
            this.btn_16.Text = "*";
            this.btn_16.UseVisualStyleBackColor = true;
            this.btn_16.Click += new System.EventHandler(this.btn_16_Click);
            // 
            // btn_20
            // 
            this.btn_20.Location = new System.Drawing.Point(284, 134);
            this.btn_20.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_20.Name = "btn_20";
            this.btn_20.Size = new System.Drawing.Size(81, 55);
            this.btn_20.TabIndex = 8;
            this.btn_20.Text = "/";
            this.btn_20.UseVisualStyleBackColor = true;
            this.btn_20.Click += new System.EventHandler(this.btn_20_Click);
            // 
            // btn_24
            // 
            this.btn_24.Location = new System.Drawing.Point(284, 75);
            this.btn_24.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_24.Name = "btn_24";
            this.btn_24.Size = new System.Drawing.Size(81, 55);
            this.btn_24.TabIndex = 9;
            this.btn_24.Text = "Del";
            this.btn_24.UseVisualStyleBackColor = true;
            this.btn_24.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(193, 323);
            this.btn_7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(86, 60);
            this.btn_7.TabIndex = 10;
            this.btn_7.Text = "3";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(103, 323);
            this.btn_6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(85, 60);
            this.btn_6.TabIndex = 11;
            this.btn_6.Text = "2";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(11, 323);
            this.btn_5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(89, 60);
            this.btn_5.TabIndex = 12;
            this.btn_5.Text = "1";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_11
            // 
            this.btn_11.Location = new System.Drawing.Point(193, 259);
            this.btn_11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_11.Name = "btn_11";
            this.btn_11.Size = new System.Drawing.Size(87, 60);
            this.btn_11.TabIndex = 13;
            this.btn_11.Text = "6";
            this.btn_11.UseVisualStyleBackColor = true;
            this.btn_11.Click += new System.EventHandler(this.btn_11_Click);
            // 
            // btn_10
            // 
            this.btn_10.Location = new System.Drawing.Point(103, 259);
            this.btn_10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(85, 60);
            this.btn_10.TabIndex = 14;
            this.btn_10.Text = "5";
            this.btn_10.UseVisualStyleBackColor = true;
            this.btn_10.Click += new System.EventHandler(this.btn_10_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(11, 259);
            this.btn_9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(87, 60);
            this.btn_9.TabIndex = 15;
            this.btn_9.Text = "4";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_15
            // 
            this.btn_15.Location = new System.Drawing.Point(193, 193);
            this.btn_15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_15.Name = "btn_15";
            this.btn_15.Size = new System.Drawing.Size(87, 62);
            this.btn_15.TabIndex = 16;
            this.btn_15.Text = "9";
            this.btn_15.UseVisualStyleBackColor = true;
            this.btn_15.Click += new System.EventHandler(this.btn_15_Click);
            // 
            // btn_14
            // 
            this.btn_14.Location = new System.Drawing.Point(103, 193);
            this.btn_14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_14.Name = "btn_14";
            this.btn_14.Size = new System.Drawing.Size(85, 62);
            this.btn_14.TabIndex = 17;
            this.btn_14.Text = "8";
            this.btn_14.UseVisualStyleBackColor = true;
            this.btn_14.Click += new System.EventHandler(this.btn_14_Click);
            // 
            // btn_13
            // 
            this.btn_13.Location = new System.Drawing.Point(11, 193);
            this.btn_13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_13.Name = "btn_13";
            this.btn_13.Size = new System.Drawing.Size(87, 62);
            this.btn_13.TabIndex = 18;
            this.btn_13.Text = "7";
            this.btn_13.UseVisualStyleBackColor = true;
            this.btn_13.Click += new System.EventHandler(this.btn_13_Click);
            // 
            // btn_19
            // 
            this.btn_19.Location = new System.Drawing.Point(193, 134);
            this.btn_19.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_19.Name = "btn_19";
            this.btn_19.Size = new System.Drawing.Size(87, 55);
            this.btn_19.TabIndex = 20;
            this.btn_19.Text = "O";
            this.btn_19.UseVisualStyleBackColor = true;
            // 
            // btn_18
            // 
            this.btn_18.Location = new System.Drawing.Point(103, 134);
            this.btn_18.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_18.Name = "btn_18";
            this.btn_18.Size = new System.Drawing.Size(85, 55);
            this.btn_18.TabIndex = 21;
            this.btn_18.Text = "EC";
            this.btn_18.UseVisualStyleBackColor = true;
            // 
            // btn_17
            // 
            this.btn_17.Location = new System.Drawing.Point(11, 134);
            this.btn_17.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_17.Name = "btn_17";
            this.btn_17.Size = new System.Drawing.Size(89, 55);
            this.btn_17.TabIndex = 22;
            this.btn_17.Text = "D";
            this.btn_17.UseVisualStyleBackColor = true;
            // 
            // btn_23
            // 
            this.btn_23.Location = new System.Drawing.Point(193, 75);
            this.btn_23.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_23.Name = "btn_23";
            this.btn_23.Size = new System.Drawing.Size(87, 55);
            this.btn_23.TabIndex = 23;
            this.btn_23.Text = "Y";
            this.btn_23.UseVisualStyleBackColor = true;
            // 
            // btn_22
            // 
            this.btn_22.Location = new System.Drawing.Point(103, 75);
            this.btn_22.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_22.Name = "btn_22";
            this.btn_22.Size = new System.Drawing.Size(85, 55);
            this.btn_22.TabIndex = 24;
            this.btn_22.Text = "NL";
            this.btn_22.UseVisualStyleBackColor = true;
            // 
            // btn_21
            // 
            this.btn_21.Location = new System.Drawing.Point(11, 75);
            this.btn_21.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_21.Name = "btn_21";
            this.btn_21.Size = new System.Drawing.Size(89, 55);
            this.btn_21.TabIndex = 25;
            this.btn_21.Text = "O";
            this.btn_21.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.btn_21);
            this.Controls.Add(this.btn_22);
            this.Controls.Add(this.btn_23);
            this.Controls.Add(this.btn_17);
            this.Controls.Add(this.btn_18);
            this.Controls.Add(this.btn_19);
            this.Controls.Add(this.btn_13);
            this.Controls.Add(this.btn_14);
            this.Controls.Add(this.btn_15);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_10);
            this.Controls.Add(this.btn_11);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_24);
            this.Controls.Add(this.btn_20);
            this.Controls.Add(this.btn_16);
            this.Controls.Add(this.btn_12);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.textboxdisplay);
            this.Controls.Add(this.btn_4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Caculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.TextBox textboxdisplay;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_12;
        private System.Windows.Forms.Button btn_16;
        private System.Windows.Forms.Button btn_20;
        private System.Windows.Forms.Button btn_24;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_11;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_15;
        private System.Windows.Forms.Button btn_14;
        private System.Windows.Forms.Button btn_13;
        private System.Windows.Forms.Button btn_19;
        private System.Windows.Forms.Button btn_18;
        private System.Windows.Forms.Button btn_17;
        private System.Windows.Forms.Button btn_23;
        private System.Windows.Forms.Button btn_22;
        private System.Windows.Forms.Button btn_21;
    }
}

