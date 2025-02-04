using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravDocGen
{
    partial class mainForm
    {
        private PrintDocument printDocument;

        int z = 150;     //X,y axis margin

        private void InitializePrintDocument()
        {
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            loadPrintSetup();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define values
            string issuingState = cmbIssuingState.Text.ToUpper();                   //01

            string document = txtDocument.Text.ToUpper();                           //02
            string type = txtType.Text.ToUpper();                                   //03
            string issuingStateCode = txtStateCode.Text.ToUpper();                  //04
            string passportNumber = txtDocNumber.Text.ToUpper();                    //05

            string surname = txtSurname.Text.ToUpper().Trim();                      //06
            string otherNames = txtOtherNames.Text.ToUpper().Trim();                //07
            string nationality = txtNationality.Text.ToUpper();                     //08

            string dateOfBirth = dtpDOB.Value.ToString("dd/MM/yyyy");               //09
            string personalNumber = txtIDNumber.Text.ToUpper();                     //10

            string sex = txtSex.Text.ToUpper();                                     //11
            string placeOfBirth = txtPlaceOfBirth.Text.ToUpper().Trim();            //12

            string dateOfIssue = dtpDateOfIssue.Value.ToString("dd/MM/yyyy");       //14
            string authority = txtIssuingAuthority.Text.ToUpper();                  //15

            string dateOfExpiry = dtpDateOfExpiry.Value.ToString("dd/MM/yyyy");     //16
            string signature = txtSignature.Text;                                   //18

            Image photo = pbPhoto.Image;                                            //19

            string mrz1 = txtMRZ1.Text.ToUpper();                                   //20
            string mrz2 = txtMRZ2.Text.ToUpper();                                   //21

            try
            {

                // Define fonts
                Font titleFont = new Font("Arial", 16, FontStyle.Bold);
                Font detailFont = new Font("Arial", 6);
                Font valueFont = new Font("Arial", 8);
                Font mrzFont = new Font("OCR B MT", 10);
                Font sigFont = new Font("Edwardian Script ITC", 10);

                // Ensure titleFont fonts are properly initialized
                if (titleFont == null)
                {
                    MessageBox.Show("The titleFont font could not be initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure detailFont fonts are properly initialized
                if (detailFont == null)
                {
                    MessageBox.Show("The detailFont font could not be initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure valueFont fonts are properly initialized
                if (valueFont == null)
                {
                    MessageBox.Show("The valueFont font could not be initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure mrzFont fonts are properly initialized
                if (mrzFont == null)
                {
                    MessageBox.Show("The mrzFont font could not be initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure sigFont fonts are properly initialized
                if (sigFont == null)
                {
                    MessageBox.Show("The sigFont font could not be initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // Define pen for drawing rectangle
                Pen gPen = new Pen(Color.LightGray, 1);

                // Define rectangle position and size
                Rectangle rect = new Rectangle(z, z, 500, 320);

                // Draw rectangle border on the page
                e.Graphics.DrawRectangle(gPen, rect);


                // Iterate through each row in the DataTable
                foreach (DataRow row in dtPrintSetup.Rows)
                {
                    // Access each column value using the column name or index
                    int id = Convert.ToInt32((string)row["FieldID"]);
                    string name = (string)row["FieldName"];
                    int X = Convert.ToInt32((string)row["xCoordinate"]) + z;
                    int Y = Convert.ToInt32((string)row["yCoordinate"]) + z;
                    int x = X - 5;
                    int y = Y - 8;

                    switch (id)
                    {
                        // Draw zone I
                        case 1:
                            e.Graphics.DrawString(issuingState, titleFont, Brushes.Black, new PointF(X, Y));
                            break;
                        case 2:
                            e.Graphics.DrawString(document, valueFont, Brushes.Black, new PointF(X, Y)); 
                            break;
                        case 3:
                            e.Graphics.DrawString(name, detailFont, Brushes.Black, new PointF(x, y));
                            e.Graphics.DrawString(type, valueFont, Brushes.Black, new PointF(X, Y)); 
                            break;
                        case 4:
                            e.Graphics.DrawString(name, detailFont, Brushes.Black, new PointF(x, y));
                            e.Graphics.DrawString(issuingStateCode, valueFont, Brushes.Black, new PointF(X, Y));
                            break;
                        case 5:
                            e.Graphics.DrawString(name, detailFont, Brushes.Black, new PointF(x, y));
                            e.Graphics.DrawString(passportNumber, valueFont, Brushes.Black, new PointF(X, Y));
                            break;

                        // Draw zone II
                        case 6:
                            e.Graphics.DrawString(name, detailFont, Brushes.Black, new PointF(x, y));
                            e.Graphics.DrawString(surname, valueFont, Brushes.Black, new PointF(X, Y));
                            break;
                        case 7:
                            e.Graphics.DrawString(name, detailFont, Brushes.Black, new PointF(x, y));
                            e.Graphics.DrawString(otherNames, valueFont, Brushes.Black, new PointF(X, Y));
                            break;
                        case 8:
                            e.Graphics.DrawString(name, detailFont, Brushes.Black, new PointF(x, y));
                            e.Graphics.DrawString(nationality, valueFont, Brushes.Black, new PointF(X, Y));
                            break;

                        // Draw zone III
                        case 9:
                            e.Graphics.DrawString(name, detailFont, Brushes.Black, new PointF(x, y));
                            e.Graphics.DrawString(dateOfBirth, valueFont, Brushes.Black, new PointF(X, Y));
                            break;
                        case 10:
                            e.Graphics.DrawString(name, detailFont, Brushes.Black, new PointF(x, y));
                            e.Graphics.DrawString(personalNumber, valueFont, Brushes.Black, new PointF(X, Y));
                            break;
                        case 11:
                            e.Graphics.DrawString(name, detailFont, Brushes.Black, new PointF(x, y));
                            e.Graphics.DrawString(sex, valueFont, Brushes.Black, new PointF(X, Y));
                            break;
                        case 12:
                            e.Graphics.DrawString(name, detailFont, Brushes.Black, new PointF(x, y));
                            e.Graphics.DrawString(placeOfBirth, valueFont, Brushes.Black, new PointF(X, Y));
                            break;
                        case 14:
                            e.Graphics.DrawString(name, detailFont, Brushes.Black, new PointF(x, y));
                            e.Graphics.DrawString(dateOfIssue, valueFont, Brushes.Black, new PointF(X, Y));
                            break;
                        case 15:
                            e.Graphics.DrawString(name, detailFont, Brushes.Black, new PointF(x, y));
                            e.Graphics.DrawString(authority, valueFont, Brushes.Black, new PointF(X, Y));
                            break;
                        case 16:
                            e.Graphics.DrawString(name, detailFont, Brushes.Black, new PointF(x, y));
                            e.Graphics.DrawString(dateOfExpiry, valueFont, Brushes.Black, new PointF(X, Y));
                            break;

                        // Draw zone IV
                        case 18:
                            e.Graphics.DrawString(name, detailFont, Brushes.Black, new PointF(x, y));
                            e.Graphics.DrawString(signature, sigFont, Brushes.Black, new PointF(X, Y));
                            break;

                        // Draw zone V
                        case 19:
                            Rectangle photoRect = new Rectangle(X, Y, 115, 156);
                            e.Graphics.DrawImage(ResizeImageWithAspectRatio(photo, 115, 156), photoRect);
                            break;

                        // Draw zone VII
                        case 20:
                            e.Graphics.DrawString(mrz1, mrzFont, Brushes.Black, new PointF(X, Y));
                            break;
                        case 21:
                            e.Graphics.DrawString(mrz2, mrzFont, Brushes.Black, new PointF(X, Y));
                            break;

                        default:
                            break;
                    }
                }

                MessageBox.Show("Printing successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while printing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private Image ResizeImageWithAspectRatio(Image image, int maxWidth, int maxHeight)
        {
            // Calculate the new dimensions while maintaining the aspect ratio
            int originalWidth = image.Width;
            int originalHeight = image.Height;
            float ratioX = (float)maxWidth / originalWidth;
            float ratioY = (float)maxHeight / originalHeight;
            float ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            // Create a new bitmap with the new dimensions
            Bitmap resizedBitmap = new Bitmap(newWidth, newHeight);

            // Create a graphics object from the bitmap
            using (Graphics graphics = Graphics.FromImage(resizedBitmap))
            {
                // Set the interpolation mode for better quality
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Draw the original image onto the new bitmap with the new size
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            // Return the resized bitmap
            return resizedBitmap;
        }

    }


    
}
