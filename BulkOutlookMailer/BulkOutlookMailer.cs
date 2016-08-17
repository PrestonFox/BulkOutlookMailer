using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BulkOutlookMailer
{
    public partial class BulkOutlookMailer : Form
    {
        public BulkOutlookMailer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileDialogHandler();
        }

        private void FileDialogHandler()
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "File Explorer";
            fdlg.InitialDirectory = @"C:\";
            fdlg.Filter = "Only CSV Files (*.csv) | *.csv";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fileDialogBox.Text = fdlg.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            Dictionary<string, string> returnedValues = email.ReplaceBodyWithPersonSpecificValues(fileDialogBox.Text, body.Text);
            string signature = email.ReadSignature();
            if (sendAsDifferentUserCheckbox.Checked)
            {
                email.CreateAndSendEmailUsingDifferentAccount(subjectTxt.Text, returnedValues.First().Key, returnedValues.First().Value, senderAddressTxt.Text.Trim(), signature, true);
            }
            else
            {
                email.CreateAndSendEmail(subjectTxt.Text, returnedValues.First().Key, returnedValues.First().Value, signature, true);
            }   
        }

        private void sendEmailsBtn_Click(object sender, EventArgs e)
        {
            sendEmailsBtn.Enabled = false;
            Email email = new Email();
            string signature = email.ReadSignature();
            Dictionary<string, string> returnedValues = email.ReplaceBodyWithPersonSpecificValues(fileDialogBox.Text, body.Text);
            int counter = 0;
            foreach (KeyValuePair<string,string> valuePair in returnedValues)
            {
                if (sendAsDifferentUserCheckbox.Checked)
                {
                    email.CreateAndSendEmailUsingDifferentAccount(subjectTxt.Text, valuePair.Key, valuePair.Value, senderAddressTxt.Text.Trim(), signature);
                }
                else
                {
                    email.CreateAndSendEmail(subjectTxt.Text, valuePair.Key, valuePair.Value, signature);
                }
                counter++;
            }
            MessageBox.Show(counter + " emails have been sent!");
            sendEmailsBtn.Enabled = true;
        }

        private void sendAsDifferentUserCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (sendAsDifferentUserCheckbox.Checked) {
                senderAddressTxt.Enabled = true;
            }
            else
            {
                senderAddressTxt.Text = "";
                senderAddressTxt.Enabled = false;
            }
            
        }
    }
}
