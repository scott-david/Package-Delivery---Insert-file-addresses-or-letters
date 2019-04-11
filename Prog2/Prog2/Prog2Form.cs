/*Prog 2
 * Grading ID: D3051
 * due date: 10/23/17
 * CIS 200-76
 * This program has us create a form, where there a several items in the 
 * menustrip. We allow the user to insert and address and letter, we also
 * allow the user to have the form list the address and letters.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp

{
    public partial class Prog2Form : Form
    {
        private UserParcelView upv; // The UserParcelView
        // Preconditon: None 
        // Postconditon: Prog2 form is initialized
        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView();
            // test data
            upv.AddAddress("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            upv.AddAddress("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            upv.AddAddress("John Doe", "111 Market St.",
                "Jeffersonville", "IN", 47130); // Test Address 5
            upv.AddAddress("Jane Smith", "55 Hollywood Blvd.", "Apt. 9",
                "Los Angeles", "CA", 90212); // Test Address 6
            upv.AddAddress("Captain Robert Crunch", "21 Cereal Rd.", "Room 987",
                "Bethesda", "MD", 20810); // Test Address 7
            upv.AddAddress("Vlad Dracula", "6543 Vampire Way", "Apt. 1",
                "Bloodsucker City", "TN", 37210); // Test Address 8

            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(1), 5.00M);// Letter test object
            upv.AddLetter(upv.AddressAt(2), upv.AddressAt(3), 2.50M);// Letter test object
            upv.AddGroundPackage(upv.AddressAt(4), upv.AddressAt(5), 4.5, 5.0, 10, 25); //groundpackage test object
            upv.AddGroundPackage(upv.AddressAt(6), upv.AddressAt(7), 7, 5, 10, 30);// groundpackage test object
            upv.AddNextDayAirPackage(upv.AddressAt(6), upv.AddressAt(0), 10, 15, 8.5, 10, 20.50M);//NextDayAirPackage test object
            upv.AddNextDayAirPackage(upv.AddressAt(3), upv.AddressAt(7), 15, 18, 20, 45, 50.75M);//NextDayAirPackage test object
            upv.AddTwoDayAirPackage(upv.AddressAt(2), upv.AddressAt(7), 12, 14, 11, 34, TwoDayAirPackage.Delivery.Saver);//TwoDayAirPackage test object
            upv.AddTwoDayAirPackage(upv.AddressAt(1), upv.AddressAt(5), 10, 5, 19, 48, TwoDayAirPackage.Delivery.Early);//TwoDayAirPackage test objec

        }


        // Precondition: aboutToolStripMenuItem has been clicked
        // Postcondition: a dialog box will display with Grading ID, section number, etc
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Progam 2\n" + "Grading ID: D3051\n" + "Section: CIS 200-76\n" + "Fall 2017");

        }
        // Precondition: exitToolStripMenuItem has been clicked
        // Postcondition: Prog2Form will close
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Precondition: addressToolStripMenuItem has been clicked
        // Postcondition: AddressForm has appeared
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            Prog2.AddressForm addressObject = new Prog2.AddressForm();
            result = addressObject.ShowDialog();
            int zip; 
            if (result == DialogResult.OK)
            {
                zip = int.Parse(addressObject.ZipValue); 
                upv.AddAddress(addressObject.NameValue,addressObject.AddressValue, addressObject.CityValue, addressObject.StateValue, zip);
                
            }

        }
        // Precondition: letterToolStripMenuItem has been clicked
        // Postcondition: LetterForm has appeared
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult letterResult;
            Prog2.LetterForm letterObject = new Prog2.LetterForm();
            letterResult = letterObject.ShowDialog();
            decimal cost;
            if (letterResult == DialogResult.OK)
            {
                cost = decimal.Parse(letterObject.Cost);
                upv.AddLetter(letterObject.OriginCombo, letterObject.DestCombo, cost);
            }
        }
        // Precondition: listAddressesToolStripMenuItem has been clicked
        // Postcondition: list of address has appeared
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var address in upv.AddressList)
            {
                textBox1.AppendText(address.ToString());
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText("------------------------".ToString());
                textBox1.AppendText(Environment.NewLine);

            }
        }
        // Precondition: listParcelsToolStripMenuItem has been clicked
        // Postcondition: list of parcels has appeared
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var parcel in upv.ParcelList)
            {
                textBox1.AppendText(parcel.ToString());
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText("------------------------".ToString());
                textBox1.AppendText(Environment.NewLine);

            }
        }
        //private void Prog2Form_Load(object sender, EventArgs e)
        //{
            
        //}
    }
}
