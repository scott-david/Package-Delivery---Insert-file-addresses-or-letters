// the letterform is made to let the user choose from a combobox of where the
// origin address is and the dest address is. It also gives them a textbox 
// to add a fixed cost.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class LetterForm : Form
    {
        List<Address> addresses;
        // need a field that is a list of addresses so it can take data from 
        // parameter and store it so it will go to load event

        public LetterForm()
        {
            InitializeComponent();//addresses = new List<Address>();
        }

        // Precondition:  cancel button has been clicked 
        // Postcondition: LetterForm is dismissed
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Precondition:  Checks to see if all children have validated
        // Postcondition: if children have validated, AddressForm is dismissed
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
        // Precondition:  originAddressComboBox_Validating succeeded
        // Postcondition: Any error message set is cleared
        private void originAddressComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(originAddressComboBox, "");
        }
        // Precondition: Attempts to change focus from originAddressComboBox
        // Postcondition: If value is valid, focus will change, if not, focus will remain
        // and error provider will appear 
        private void originAddressComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (originAddressComboBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(originAddressComboBox, "Select origin address");
            }
        }
        // Precondition:  destAddressComboBox_Validating succeeded
        // Postcondition: Any error message set is cleared
        private void destAddressComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(destAddressComboBox, "");
        }
        // Precondition: Attempts to change focus from destAddressComboBox
        // Postcondition: If value is valid, focus will change, if not, focus will remain
        // and error provider will appear 
        private void destAddressComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (destAddressComboBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(destAddressComboBox, "Select destination address");
            }
        }
        // Precondition:  fixedCostTextBox_Validating succeeded
        // Postcondition: Any error message set is cleared
        private void fixedCostTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(fixedCostTextBox, "");
        }
        // Precondition: Attempts to change focus from fixedCostTextBox
        // Postcondition: If value is valid, focus will change, if not, focus will remain
        // and error provider will appear 
        private void fixedCostTextBox_Validating(object sender, CancelEventArgs e)
        {/*
            decimal fcost;
            if(decimal.Parse(fixedCostTextBox.Text, out fcost)
            { }
            */


        }

        internal string OriginCombo
        {
            // Precondition:  None
            // Postcondition: Text in originAddressComboBox is returned
            get { return originAddressComboBox.Text; }
            // Precondition:  None
            // Postcondition: Text in originAddressComboBox is set to specified value
            set { originAddressComboBox.Text = value; }
        }
        internal string DestCombo
        {
            // Precondition:  None
            // Postcondition: Text in destAddressComboBox is returned
            get { return destAddressComboBox.Text; }
            // Precondition:  None
            // Postcondition: Text in destAddressComboBox is set to specified value
            set { destAddressComboBox.Text = value; }
        }
        internal string Cost
        {
            // Precondition:  None
            // Postcondition: Text in fixedCostTextBox is returned
            get { return fixedCostTextBox.Text.ToString(); }
            // Precondition:  None
            // Postcondition: Text in fixedCostTextBox is set to specified value
            set { fixedCostTextBox.Text = value; }
        }
        public decimal TotalCost()
        {
            decimal cost; // running total of cost of letters

            cost = decimal.Parse(fixedCostTextBox.Text);
            return cost;
        }

    }  
}
