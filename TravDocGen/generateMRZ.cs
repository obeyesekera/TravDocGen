using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravDocGen
{
    partial class mainForm
    {
        private void generateMRZ()
        {
            string MRZ = GenerateMRZ(txtType.Text, txtDocNumber.Text, txtSurname.Text, txtOtherNames.Text, txtNationality.Text, dtpDOB.Value, txtSex.Text, dtpDateOfExpiry.Value, txtIDNumber.Text);
        
            txtMRZ1.Text = MRZ.Split('\n')[0];
            txtMRZ2.Text = MRZ.Split('\n')[1];

        }

        // Method to calculate the checksum for a given string
        private static int CalculateChecksum(string data)
        {
            string weights = "731";
            int sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                char c = data[i];
                int value;
                if (char.IsDigit(c))
                    value = c - '0';
                else if (char.IsLetter(c))
                    value = c - 'A' + 10;
                else
                    value = 0;

                sum += value * (weights[i % 3] - '0');
            }
            return sum % 10;
        }

        public static string GenerateMRZ(string passportType, string passportNumber, string surname, string givenNames, string nationality, DateTime birthDate, string sex, DateTime expiryDate, string idNumber)
        {
            // Line 1: PP<Nationality<<Surname<<GivenNames
            StringBuilder line1 = new StringBuilder();
            line1.Append(passportType.ToUpper().PadRight(2, '<'));          // 1 to 2 Passport Type
            line1.Append(nationality.ToUpper());                            // 3 to 5 Nationalality
            line1.Append(surname.ToUpper().Trim().Replace(" ", "<"));       // 6 to 44 Surname + Given Names
            line1.Append("<<");
            line1.Append(givenNames.ToUpper().Trim().Replace(" ", "<"));

            // Ensure line 1 is exactly 44 characters
            while (line1.Length < 44) line1.Append('<');

            // Line 2: PassportNumber<CheckDigitNationalityBirthDate<CheckDigitSexExpiryDate<CheckDigitIDNumber<CheckDigitCompositCheckDigit
            StringBuilder line2 = new StringBuilder();
            line2.Append(passportNumber.ToUpper().PadRight(9, '<'));        //1 to 9 Passport Number
            line2.Append(CalculateChecksum(passportNumber.ToUpper()));      //10 Check digit for 1 to 9
            line2.Append(nationality.ToUpper());                            //11 to 13 Nationality
            line2.Append(birthDate.ToString("yyMMdd"));                     //14 to 19 DOB
            line2.Append(CalculateChecksum(birthDate.ToString("yyMMdd")));  //20 Check digit for 14 to 19
            line2.Append(sex.ToUpper());                                    //21 Gender
            line2.Append(expiryDate.ToString("yyMMdd"));                    //22 to 27 Expity Date
            line2.Append(CalculateChecksum(expiryDate.ToString("yyMMdd"))); //28 Check digit for 22 to 27
            line2.Append(idNumber.ToUpper().PadRight(14, '<'));             //29 to 42 ID Number
            if (idNumber.Length>0)                                          //43 Check digit for 29 to 42
            {
                line2.Append(CalculateChecksum(idNumber.ToUpper()));
            }
            else
            {
                line2.Append("0");
            }

            // Calculate the composite checksum
            string composite = line2.ToString().Substring(0, 10).Replace("<","")        //1 to 10 Passport Number + Check Digit
                              + line2.ToString().Substring(13, 7).Replace("<", "")      //14 to 20 DOB + Check Digit
                              + line2.ToString().Substring(21, 22).Replace("<", "");    //22 to 43 Expiry Date + ID Number + Check Digit

            // Ensure line 2 is exactly 44 characters
            line2.Append(CalculateChecksum(composite));

            // Combine the two lines for the MRZ
            return line1.ToString().Substring(0,44) + "\n" + line2.ToString();

            
        }
    }
}
