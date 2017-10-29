using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityForms
{
    public partial class SecurityForms : MetroFramework.Forms.MetroForm
    {
        Classes.CeaserCipherClass ccObj = new Classes.CeaserCipherClass();
        Classes.MonoalphabeticClass maobj = new Classes.MonoalphabeticClass();
        Classes.RailFenceClass rfobj = new Classes.RailFenceClass();
        Classes.PlayFairClass pfobj = new Classes.PlayFairClass();
        Classes.PolyalphabeticClass paobj = new Classes.PolyalphabeticClass();
        public SecurityForms()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EncBTN_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseType.SelectedIndex == 0)
            {
               EncryptionMessageTXT.Text= ccObj.Encipher(MessageTXT.Text.ToString(),Convert.ToInt16(keyTXT.Text));
            }
            if (comboBoxChooseType.SelectedIndex == 1)
            {
                EncryptionMessageTXT.Text = maobj.Encrypt(MessageTXT.Text.ToString(), keyTXT.Text);
            }
            if (comboBoxChooseType.SelectedIndex == 2)
            {
                EncryptionMessageTXT.Text = pfobj.Encipher(MessageTXT.Text.ToString(), keyTXT.Text);
                
            }
            if (comboBoxChooseType.SelectedIndex == 3)
            {
                EncryptionMessageTXT.Text = paobj.Encipher(MessageTXT.Text.ToString(), keyTXT.Text);

            }
            if (comboBoxChooseType.SelectedIndex == 4)
            {
               EncryptionMessageTXT.Text= rfobj.Encrypt(MessageTXT.Text, keyTXT.Text);
            }

        }

        private void DecBTN_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseType.SelectedIndex == 0)
            {
                DecryptionMessageTXT.Text = ccObj.Decipher(EncryptionMessageTXT.Text.ToString(), Convert.ToInt16(keyTXT.Text));
            }
            if (comboBoxChooseType.SelectedIndex == 1)
            {
                DecryptionMessageTXT.Text = maobj.Decrypt(EncryptionMessageTXT.Text.ToString(), keyTXT.Text);
            }
            if (comboBoxChooseType.SelectedIndex == 2)
            {
                DecryptionMessageTXT.Text = pfobj.Decipher(EncryptionMessageTXT.Text.ToString(), keyTXT.Text);

            }
            if (comboBoxChooseType.SelectedIndex == 3)
            {
                DecryptionMessageTXT.Text = paobj.Decipher(EncryptionMessageTXT.Text.ToString(), keyTXT.Text);

            }
            if (comboBoxChooseType.SelectedIndex == 4)
            {
                DecryptionMessageTXT.Text = rfobj.Decrypt(EncryptionMessageTXT.Text, keyTXT.Text);

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                keyTXT.UseSystemPasswordChar = true;
            }
            else
            {
                keyTXT.UseSystemPasswordChar=false;
            }
        }
    }
}
