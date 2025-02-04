using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravDocGen
{
    partial class mainForm
    {

        private readonly Random _random = new Random();

        public int randomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private void getNewDoc()
        {
            txtDocNumber.Text = rndTravelDoc(tdPrefix);
            txtSurname.Text = generateName(10);
            txtOtherNames.Text = generateName(8);
            dtpDOB.Value = rndDOB();
            txtIDNumber.Text = randomNumber(100000000, 999999999).ToString();
            txtSex.Text = rndGender();
            txtPlaceOfBirth.Text = generateName(10);
            dtpDateOfIssue.Value = rndIssueDate();
            dtpDateOfExpiry.Value = rndExpiryDate(dtpDateOfIssue.Value);
            setSignature();
        }

        private void setSignature()
        {
            if ((txtOtherNames.Text.Length>0)&& (txtSurname.Text.Length > 0))
            {
                txtSignature.Text = txtOtherNames.Text.Substring(0, 1) + ". " + txtSurname.Text;

            }
        }

        private string rndTravelDoc(string prefix)
        {
            var tdBuilder = new StringBuilder();
            tdBuilder.Append(prefix);
            tdBuilder.Append(randomNumber(10000, 99999));

            return tdBuilder.ToString();
        }

        public static string generateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;
        }

        private DateTime rndDOB()
        {
            DateTime start = new DateTime(1945, 1, 1);
            int range = (DateTime.Today - start).Days;
            //return start.AddDays(_random.Next(range)).ToString("dd/MM/yyyy");
            return start.AddDays(_random.Next(range));
        }

        private string rndGender()
        {
            string[] genders = { "M", "F" };

            int rNo = randomNumber(0, 1000);
            int index = rNo % 2;
            return genders[index];
        }


        private DateTime rndIssueDate()
        {
            DateTime start = DateTime.Today;
            int range = 100;
            return start.AddDays(-_random.Next(range));
        }

        private DateTime rndExpiryDate(DateTime issueDate)
        {
            DateTime start = issueDate;
            int range = 3650;
            return start.AddDays(range);
        }

        private void loadPhoto()
        {
            // open file dialog
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                //pbPhoto.Image = new Bitmap(open.FileName);
                // image file path
                //textBox1.Text = open.FileName;

                setPhoto(open.FileName);
            }
        }

        private void setPhoto(string fileName)
        {
            pbPhoto.Image = new Bitmap(fileName);
        }
    }
}
