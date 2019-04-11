// AddressForm.cs
// Shows modal dialog box, which allows user to input name, address,
// city, state, and zip
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
    public partial class AddressForm : Form
    {


        // Precondition:  None
        // Postcondition: AddressForm GUI is initialized
        public AddressForm()
        {
            InitializeComponent();
        }

        public const int MIN_ZIP = 00000; // Minimum ZipCode value
        public const int MAX_ZIP = 99999; // Maximum ZipCode value
        // Precondition:  cancelButton has been clicked
        // Postcondition: AddressForm is dismissed
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Precondition: Checks to see if all children has validated
        // Postcondition: if children have validated, AddressForm is dismissed
        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        // Precondition: Attempts to change focus from zipTextBox
        // Postcondition: If value is valid, focus will change, if not, focus will remain
        // and error provider will appear 
        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nameTextBox.Text == "")
            {

                e.Cancel = true;
                errorProvider1.SetError(nameTextBox, "Enter a name"); // clears the error message
            }
        }
        // Precondition:  nameTextBox_Validating succeeded
        // Postcondition: Any error message set is cleared
        private void nameTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(nameTextBox, ""); // clears the error message
        }
        // Precondition:  addressTextBox_Validating succeeded
        // Postcondition: Any error message set is cleared
        private void addressTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(addressTextBox, "");
        }
        // Precondition: Attempts to change focus from addressTextBox
        // Postcondition: If value is valid, focus will change, if not, focus will remain
        // and error provider will appear 
        private void addressTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (addressTextBox.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(addressTextBox, "Enter an address");
            }
        }
        // Precondition:  cityTextBox_Validating succeeded
        // Postcondition: Any error message set is cleared
        private void cityTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cityTextBox, "");
        }
        // Precondition: Attempts to change focus from cityTextBox
        // Postcondition: If value is valid, focus will change, if not, focus will remain
        // and error provider will appear 
        private void cityTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (cityTextBox.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(cityTextBox, "Enter a city");
            }
        }
        // Precondition:  zipTextBox_Validating succeeded
        // Postcondition: Any error message set is cleared
        private void zipTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(zipTextBox, ""); //clears error message
        }
        // Precondition: Attempts to change focus from zipTextBox
        // Postcondition: If value is valid, focus will change, if not, focus will remain
        // and error provider will appear 
        private void zipTextBox_Validating(object sender, CancelEventArgs e)
        {
            int zipcode; //value entered into zipTextBox
            if (!int.TryParse(zipTextBox.Text, out zipcode))
            {
                e.Cancel = true; // Will NOT proceed to Validated event

                errorProvider1.SetError(zipTextBox, "Enter a zip code!"); // Set error message

            }
            else if ((zipcode < MIN_ZIP) && (zipcode > MAX_ZIP))
            {
                e.Cancel = true;  // Will NOT proceed to Validated event

                errorProvider1.SetError(zipTextBox, "Enter a zip code!");
            }
        }
        private void stateComboBox_Validating(object sender, CancelEventArgs e)
        {/*
            int index = -1;
            if (stateComboBox.SelectedIndex = index)
                errorProvider1.SetError(stateComboBox, "Select state");*/
        }

        private void stateComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(stateComboBox, "");
        }

        internal string NameValue
        {
            // Precondition:  None
            // Postcondition: Text in nameTextBox is returned
            get { return nameTextBox.Text; }
            // Precondition:  None
            // Postcondition: Text in nameTextBox is set to specified value
            set { nameTextBox.Text = value; }
        }
        internal string AddressValue
        {
            // Precondition:  None
            // Postcondition: Text in addressTextBox is returned
            get { return addressTextBox.Text; }
            // Precondition:  None
            // Postcondition: Text in addressTextBox is set to specified value
            set { addressTextBox.Text = value; }
        }
        internal string CityValue
        {
            // Precondition:  None
            // Postcondition: Text in cityTextBox is returned
            get { return cityTextBox.Text; }
            // Precondition:  None
            // Postcondition: Text in cityTextBox is set to specified value
            set { cityTextBox.Text = value; }
        }
        internal string StateValue
        {
            // Precondition:  None
            // Postcondition: Text in stateComboBox is returned
            get { return stateComboBox.Text; }
            // Precondition:  None
            // Postcondition: Text in stateComboBox is set to specified value
            set { stateComboBox.Text = value; }
        }
        internal string ZipValue
        {
            // Precondition:  None
            // Postcondition: Text in zipTextBox is returned
            get { return zipTextBox.Text.ToString(); }
            // Precondition:  None
            // Postcondition: Text in zipTextBox is set to specified value
            set { zipTextBox.Text = value; }
        }

        
    }
}

