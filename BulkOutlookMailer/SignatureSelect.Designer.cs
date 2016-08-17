namespace BulkOutlookMailer
{
    partial class SignatureSelect
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
            this.signatureSelection = new System.Windows.Forms.ComboBox();
            this.selectSignatureBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signatureSelection
            // 
            this.signatureSelection.FormattingEnabled = true;
            this.signatureSelection.Location = new System.Drawing.Point(61, 86);
            this.signatureSelection.Name = "signatureSelection";
            this.signatureSelection.Size = new System.Drawing.Size(494, 39);
            this.signatureSelection.TabIndex = 0;
            // 
            // selectSignatureBtn
            // 
            this.selectSignatureBtn.Location = new System.Drawing.Point(166, 156);
            this.selectSignatureBtn.Name = "selectSignatureBtn";
            this.selectSignatureBtn.Size = new System.Drawing.Size(258, 91);
            this.selectSignatureBtn.TabIndex = 1;
            this.selectSignatureBtn.Text = "Ok";
            this.selectSignatureBtn.UseVisualStyleBackColor = true;
            this.selectSignatureBtn.Click += new System.EventHandler(this.selectSignatureBtn_Click);
            // 
            // SignatureSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 279);
            this.Controls.Add(this.selectSignatureBtn);
            this.Controls.Add(this.signatureSelection);
            this.Name = "SignatureSelect";
            this.Text = "SignatureSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox signatureSelection;
        private System.Windows.Forms.Button selectSignatureBtn;
    }
}