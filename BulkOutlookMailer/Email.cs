using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Windows.Forms;

namespace BulkOutlookMailer
{
    public class Email
    {
        public void CreateAndSendEmail(string subjectEmail, string toEmail, string bodyEmail, string signature, bool isPreview = false)
        {
            Outlook.Application app = new Outlook.Application();
            Outlook.MailItem eMail = app.CreateItem(Outlook.OlItemType.olMailItem);
            eMail.Subject = subjectEmail;
            eMail.To = toEmail;
            eMail.HTMLBody = bodyEmail + eMail.HTMLBody + signature;
            eMail.Importance = Outlook.OlImportance.olImportanceNormal;
            if (isPreview)
            {
                eMail.Display(true);
            }
            else
            {
                eMail.Send();
            }            
        }
        public void CreateAndSendEmailUsingDifferentAccount(string subjectEmail, string toEmail, string bodyEmail, string senderEmailAddress, string signature, bool isPreview = false)
        {
            Outlook.Application app = new Outlook.Application();
            Outlook.MailItem eMail = app.CreateItem(Outlook.OlItemType.olMailItem);
            eMail.Subject = subjectEmail;
            eMail.To = toEmail;
            eMail.HTMLBody = bodyEmail + eMail.HTMLBody + signature;
            eMail.Importance = Outlook.OlImportance.olImportanceNormal;
            Outlook.Account account = GetAccountForEmailAddress(app, senderEmailAddress);
            eMail.SendUsingAccount = account;
            if (isPreview)
            {
                eMail.Display(true);
            }
            else
            {
                eMail.Send();
            }
        }

        public Outlook.Account GetAccountForEmailAddress(Outlook.Application application, string smtpAddress)
        {

            // Loop over the Accounts collection of the current Outlook session. 
            Outlook.Accounts accounts = application.Session.Accounts;
            foreach (Outlook.Account account in accounts)
            {
                // When the e-mail address matches, return the account. 
                if (account.SmtpAddress.Trim().ToUpper() == smtpAddress.Trim().ToUpper())
                {
                    return account;
                }
            }
            throw new System.Exception(string.Format("No Account with SmtpAddress: {0} exists!", smtpAddress));
        }

        public Dictionary<string, string> ReplaceBodyWithPersonSpecificValues(string pathToCsv, string emailBody)
        {
            Dictionary<string ,string> replacedBodyOfEmailsWithAddresses = new Dictionary<string, string>();
            var reader = new StreamReader(File.OpenRead(pathToCsv));
            Dictionary<int, string[]> replacementValues = new Dictionary<int, string[]>();
            int counter = 0;
            while (!reader.EndOfStream)
            {
                string row = reader.ReadLine();
                string[] values = row.Split(',');
                replacementValues.Add(counter, values);
                counter++;
            }
            string[] headerValues = replacementValues[0];
            for (int i = 1; i <= replacementValues.Keys.Max(); i++)
            {
                string replacedEmailBody = emailBody;
                string[] valuesInCsv = replacementValues[i];
                for (int x = 0; x < valuesInCsv.Count() - 1; x++)
                {
                    replacedEmailBody = replacedEmailBody.Replace(headerValues[x], replacementValues[i][x]);
                }
                replacedBodyOfEmailsWithAddresses.Add(replacementValues[i][valuesInCsv.Count()-1], replacedEmailBody);
            }
            return replacedBodyOfEmailsWithAddresses;
        }

        public string ReadSignature()

        {
            string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Signatures";
            string signature = string.Empty;
            DirectoryInfo diInfo = new DirectoryInfo(appDataDir);
            if
            (diInfo.Exists)
            {
                FileInfo[] fiSignature = diInfo.GetFiles("*.htm");
                int signatureSelection = 0;

                //Spawn Dropdown to select which signature to choose
                if (fiSignature.Count() > 1)
                {
                    List<SignatureDropdown> signatures = new List<SignatureDropdown>();
                    int counter = 0;
                    foreach (FileInfo fileInfo in fiSignature)
                    {
                        signatures.Add(new SignatureDropdown { Displayvalue = fileInfo.Name, IndexValue = counter });
                        counter++;
                    }
                    SignatureSelect signatureSelect = new SignatureSelect(signatures);
                    var result = signatureSelect.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        signatureSelection = signatureSelect.SelectedValued;
                    }
                }

                if (fiSignature.Length > 0)
                {
                    StreamReader sr = new StreamReader(fiSignature[signatureSelection].FullName, Encoding.Default);
                    signature = sr.ReadToEnd();
                    if (!string.IsNullOrEmpty(signature))
                    {
                        string fileName = fiSignature[signatureSelection].Name.Replace(fiSignature[signatureSelection].Extension, string.Empty);
                        signature = signature.Replace(fileName + "_files/", appDataDir + "/" + fileName + "_files/");
                    }
                }

            }
            return signature;
        }
    }
}
