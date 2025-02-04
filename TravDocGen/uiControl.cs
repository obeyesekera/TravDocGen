using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TravDocGen
{
    partial class mainForm
    {
        private void initialParams()
        {
            var GetDirectory = AppContext.BaseDirectory;

            //set version info
            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = "TravDocGen " + version;
            loadCountries();
            loadDocTypes();
            setFields();
            setPhoto(GetDirectory + "\\ppFace.png");


        }

        private void setFields()
        {
            txtDocument.ReadOnly = true;
            txtType.ReadOnly = true;
            txtStateCode.ReadOnly = true;
            txtNationality.ReadOnly = true;
            txtIssuingAuthority.ReadOnly = true;
            txtSignature.ReadOnly = true;
            txtMRZ1.ReadOnly = true;
            txtMRZ2.ReadOnly = true;
            txtDocNumber.Text = "";
            txtDocNumber.MaxLength = 9;
            txtSurname.Text = "";
            txtOtherNames.Text = "";
            txtIDNumber.Text = "";
            txtIDNumber.MaxLength = 14;
            txtSex.Text = "";
            txtSex.MaxLength = 1;
            txtPlaceOfBirth.Text = "";
            txtSignature.Text = "";
            txtMRZ1.Text = "";
            txtMRZ2.Text = "";
            btnMRZ.Enabled = false;
            btnPrint.Enabled = false;
        }

        private void dataChanged()
        {
            txtMRZ1.Text = "";
            txtMRZ2.Text = "";

            enableBtnMRZ();
            enableBtnPrint();
        }


        private void InitializeToolTip()
        {
            // Create the ToolTip and associate it with the Form container.
            toolTip = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;

            // Set up the ToolTip text for the Button.
            toolTip.SetToolTip(pbPhoto, "Double Click to change photo");
            toolTip.SetToolTip(btnNew, "New");
            toolTip.SetToolTip(btnMRZ, "MRZ");
            toolTip.SetToolTip(btnPrint, "Print");
        }

        private void validateGender() {

            // Validate the entered value
            string enteredValue = txtSex.Text.ToUpper(); // Convert to uppercase for case-insensitive comparison

            if (enteredValue == "" || enteredValue == "M" || enteredValue == "F" || enteredValue == "X")
            {
                txtSex.Text = txtSex.Text.ToUpper();
            }
            else
            {
                txtSex.Text = "";
                MessageBox.Show("Please enter a valid gender (M, F, or X).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void enableBtnMRZ() {
            //txtType.Text, txtDocNumber.Text, txtSurname.Text, txtOtherNames.Text, txtNationality.Text, dtpDOB.Value, txtSex.Text, dtpDateOfExpiry.Value, txtIDNumber.Text
            if (txtDocNumber.Text != "" 
                && txtSurname.Text != "" 
                //&& txtOtherNames.Text != "" 
                && txtNationality.Text != "" 
                && txtSex.Text != "" 
                //&& txtIDNumber.Text != ""
                )
            {
                btnMRZ.Enabled = true;
            }
            else
            {
                btnMRZ.Enabled = false;
            }

        }

        private void enableBtnPrint()
        {
            if (txtMRZ1.Text != "" && txtMRZ2.Text != "" && txtPlaceOfBirth.Text !="")
            {
                btnPrint.Enabled = true;
            }
            else
            {
                btnPrint.Enabled = false;
            }
        }

        private void validateNames(KeyPressEventArgs e)
        {
            // Check if the entered character is not a control character and not an alphabet character
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                // If it's not, set e.Handled to true to prevent the character from being entered
                e.Handled = true;
                MessageBox.Show("Please enter only alphabet characters (A-Z or a-z).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void validateNumbers(KeyPressEventArgs e)
        {
            // Check if the entered character is not a control character and not an alphanumeric character
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                // If it's not, set e.Handled to true to prevent the character from being entered
                e.Handled = true;
                MessageBox.Show("Please enter only alphanumeric characters (A-Z, a-z, or 0-9).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        


    }
}
