using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkOutlookMailer
{
    public partial class SignatureSelect : Form
    {
        public int SelectedValued { get; set; }
        public SignatureSelect(List<SignatureDropdown> signatures)
        {
            InitializeComponent();
            signatureSelection.DataSource = signatures;
            signatureSelection.DisplayMember = "Displayvalue";
            signatureSelection.ValueMember = "IndexValue";
        }

        private void selectSignatureBtn_Click(object sender, EventArgs e)
        {
            SelectedValued = (int) signatureSelection.SelectedValue;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
