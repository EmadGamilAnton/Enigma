namespace SecurityForms
{
    partial class SecurityForms
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
            this.EncBTN = new System.Windows.Forms.Button();
            this.DecBTN = new System.Windows.Forms.Button();
            this.comboBoxChooseType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MessageTXT = new System.Windows.Forms.TextBox();
            this.EncryptionMessageTXT = new System.Windows.Forms.TextBox();
            this.DecryptionMessageTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.keyTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // EncBTN
            // 
            this.EncBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EncBTN.Location = new System.Drawing.Point(449, 396);
            this.EncBTN.Name = "EncBTN";
            this.EncBTN.Size = new System.Drawing.Size(99, 31);
            this.EncBTN.TabIndex = 0;
            this.EncBTN.Text = "Encryption";
            this.EncBTN.UseVisualStyleBackColor = true;
            this.EncBTN.Click += new System.EventHandler(this.EncBTN_Click);
            // 
            // DecBTN
            // 
            this.DecBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DecBTN.Location = new System.Drawing.Point(566, 396);
            this.DecBTN.Name = "DecBTN";
            this.DecBTN.Size = new System.Drawing.Size(98, 31);
            this.DecBTN.TabIndex = 1;
            this.DecBTN.Text = "Decryption";
            this.DecBTN.UseVisualStyleBackColor = true;
            this.DecBTN.Click += new System.EventHandler(this.DecBTN_Click);
            // 
            // comboBoxChooseType
            // 
            this.comboBoxChooseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseType.FormattingEnabled = true;
            this.comboBoxChooseType.Items.AddRange(new object[] {
            "Caeser Cipher",
            "Monoalphabetic Cipher",
            "Playfair Cipher",
            "Polyalphabetic Cipher",
            "Rail Fence"});
            this.comboBoxChooseType.Location = new System.Drawing.Point(200, 102);
            this.comboBoxChooseType.Name = "comboBoxChooseType";
            this.comboBoxChooseType.Size = new System.Drawing.Size(244, 24);
            this.comboBoxChooseType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Your Security Type :";
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(685, 396);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 31);
            this.exitBTN.TabIndex = 4;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Your Message :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(9, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Encrypted Message :";
            // 
            // MessageTXT
            // 
            this.MessageTXT.Location = new System.Drawing.Point(200, 150);
            this.MessageTXT.Multiline = true;
            this.MessageTXT.Name = "MessageTXT";
            this.MessageTXT.Size = new System.Drawing.Size(244, 52);
            this.MessageTXT.TabIndex = 7;
            // 
            // EncryptionMessageTXT
            // 
            this.EncryptionMessageTXT.Location = new System.Drawing.Point(200, 218);
            this.EncryptionMessageTXT.Multiline = true;
            this.EncryptionMessageTXT.Name = "EncryptionMessageTXT";
            this.EncryptionMessageTXT.ReadOnly = true;
            this.EncryptionMessageTXT.Size = new System.Drawing.Size(244, 52);
            this.EncryptionMessageTXT.TabIndex = 8;
            // 
            // DecryptionMessageTXT
            // 
            this.DecryptionMessageTXT.Location = new System.Drawing.Point(199, 309);
            this.DecryptionMessageTXT.Multiline = true;
            this.DecryptionMessageTXT.Name = "DecryptionMessageTXT";
            this.DecryptionMessageTXT.ReadOnly = true;
            this.DecryptionMessageTXT.Size = new System.Drawing.Size(244, 52);
            this.DecryptionMessageTXT.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(9, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Decrypted Message :";
            // 
            // keyTXT
            // 
            this.keyTXT.Location = new System.Drawing.Point(499, 105);
            this.keyTXT.Multiline = true;
            this.keyTXT.Name = "keyTXT";
            this.keyTXT.PasswordChar = '*';
            this.keyTXT.Size = new System.Drawing.Size(261, 75);
            this.keyTXT.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(452, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Key :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(499, 186);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Show key";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SecurityForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 448);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.keyTXT);
            this.Controls.Add(this.DecryptionMessageTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EncryptionMessageTXT);
            this.Controls.Add(this.MessageTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChooseType);
            this.Controls.Add(this.DecBTN);
            this.Controls.Add(this.EncBTN);
            this.Name = "SecurityForms";
            this.Text = "Enigma  Turing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncBTN;
        private System.Windows.Forms.Button DecBTN;
        private System.Windows.Forms.ComboBox comboBoxChooseType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MessageTXT;
        private System.Windows.Forms.TextBox EncryptionMessageTXT;
        private System.Windows.Forms.TextBox DecryptionMessageTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox keyTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

