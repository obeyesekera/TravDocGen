//using ExcelApp = Microsoft.Office.Interop.Excel;



using System.Reflection;
using System.Data;
using System.Runtime.Intrinsics.Arm;
using System.Drawing.Printing;
//using Microsoft.Office.Interop.Excel;
//using Font = System.Drawing.Font;
//using Rectangle = System.Drawing.Rectangle;
//using Application = System.Windows.Forms.Application;

namespace TravDocGen
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (excelApp == null)
            {
                MessageBox.Show("Excel is not installed!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            initialParams();
            InitializeToolTip();
        }



        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }

        private void cmbIssuingState_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataChanged();
            setCountry();
        }

        private void cmbDocType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataChanged();
            setDocType();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dataChanged();
            getNewDoc();
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            dataChanged();
            setSignature();
        }

        private void txtOtherNames_TextChanged(object sender, EventArgs e)
        {
            dataChanged();
            setSignature();

        }

        private void pbPhoto_DoubleClick(object sender, EventArgs e)
        {
            loadPhoto();
        }

        private void btnMRZ_Click(object sender, EventArgs e)
        {
            generateMRZ();
            enableBtnPrint();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            InitializePrintDocument();
            printDocument.Print();


        }

        private void txtSex_TextChanged(object sender, EventArgs e)
        {
            dataChanged();
            validateGender();
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateNames(e);
        }

        private void txtOtherNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateNames(e);
        }

        private void txtDocNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateNumbers(e);
        }

        private void txtIDNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateNumbers(e);
        }

        private void txtDocNumber_TextChanged(object sender, EventArgs e)
        {
            dataChanged();
        }

        private void txtNationality_TextChanged(object sender, EventArgs e)
        {
            dataChanged();
        }

        private void txtPlaceOfBirth_TextChanged(object sender, EventArgs e)
        {
            dataChanged();
        }

        private void txtPlaceOfBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateNames(e);
        }

        private void txtIDNumber_TextChanged(object sender, EventArgs e)
        {
            dataChanged();
        }
    }

}
