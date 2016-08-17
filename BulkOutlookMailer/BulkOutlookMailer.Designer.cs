namespace BulkOutlookMailer
{
    partial class BulkOutlookMailer
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
            this.browseBtn = new System.Windows.Forms.Button();
            this.fileDialogBox = new System.Windows.Forms.TextBox();
            this.subjectTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.previewBtn = new System.Windows.Forms.Button();
            this.sendEmailsBtn = new System.Windows.Forms.Button();
            this.sendAsDifferentUserCheckbox = new System.Windows.Forms.CheckBox();
            this.senderAddressTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(623, 530);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(307, 53);
            this.browseBtn.TabIndex = 0;
            this.browseBtn.Text = "Browse For CSV";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileDialogBox
            // 
            this.fileDialogBox.Enabled = false;
            this.fileDialogBox.Location = new System.Drawing.Point(198, 538);
            this.fileDialogBox.Name = "fileDialogBox";
            this.fileDialogBox.Size = new System.Drawing.Size(400, 38);
            this.fileDialogBox.TabIndex = 1;
            this.fileDialogBox.Text = "Select CSV File For Email";
            // 
            // subjectTxt
            // 
            this.subjectTxt.Location = new System.Drawing.Point(198, 12);
            this.subjectTxt.Name = "subjectTxt";
            this.subjectTxt.Size = new System.Drawing.Size(400, 38);
            this.subjectTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject";
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(623, 618);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(307, 63);
            this.previewBtn.TabIndex = 6;
            this.previewBtn.Text = "Preview";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // sendEmailsBtn
            // 
            this.sendEmailsBtn.Location = new System.Drawing.Point(623, 717);
            this.sendEmailsBtn.Name = "sendEmailsBtn";
            this.sendEmailsBtn.Size = new System.Drawing.Size(307, 63);
            this.sendEmailsBtn.TabIndex = 7;
            this.sendEmailsBtn.Text = "Send Emails";
            this.sendEmailsBtn.UseVisualStyleBackColor = true;
            this.sendEmailsBtn.Click += new System.EventHandler(this.sendEmailsBtn_Click);
            // 
            // sendAsDifferentUserCheckbox
            // 
            this.sendAsDifferentUserCheckbox.AutoSize = true;
            this.sendAsDifferentUserCheckbox.Location = new System.Drawing.Point(18, 683);
            this.sendAsDifferentUserCheckbox.Name = "sendAsDifferentUserCheckbox";
            this.sendAsDifferentUserCheckbox.Size = new System.Drawing.Size(338, 36);
            this.sendAsDifferentUserCheckbox.TabIndex = 8;
            this.sendAsDifferentUserCheckbox.Text = "Send as Different User";
            this.sendAsDifferentUserCheckbox.UseVisualStyleBackColor = true;
            this.sendAsDifferentUserCheckbox.CheckedChanged += new System.EventHandler(this.sendAsDifferentUserCheckbox_CheckedChanged);
            // 
            // senderAddressTxt
            // 
            this.senderAddressTxt.Enabled = false;
            this.senderAddressTxt.Location = new System.Drawing.Point(232, 739);
            this.senderAddressTxt.Name = "senderAddressTxt";
            this.senderAddressTxt.Size = new System.Drawing.Size(366, 38);
            this.senderAddressTxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 742);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sender Address";
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(198, 88);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(400, 418);
            this.body.TabIndex = 13;
            this.body.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Body";
            // 
            // BulkOutlookMailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 808);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.body);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.senderAddressTxt);
            this.Controls.Add(this.sendAsDifferentUserCheckbox);
            this.Controls.Add(this.sendEmailsBtn);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectTxt);
            this.Controls.Add(this.fileDialogBox);
            this.Controls.Add(this.browseBtn);
            this.Name = "BulkOutlookMailer";
            this.Text = "Bulk Outlook Mailer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox fileDialogBox;
        private System.Windows.Forms.TextBox subjectTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.Button sendEmailsBtn;
        private System.Windows.Forms.CheckBox sendAsDifferentUserCheckbox;
        private System.Windows.Forms.TextBox senderAddressTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox body;
        private System.Windows.Forms.Label label2;
    }
}

