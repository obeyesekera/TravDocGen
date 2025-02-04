
namespace TravDocGen
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            cmbIssuingState = new ComboBox();
            txtDocument = new TextBox();
            txtType = new TextBox();
            txtStateCode = new TextBox();
            txtDocNumber = new TextBox();
            txtSurname = new TextBox();
            txtOtherNames = new TextBox();
            txtNationality = new TextBox();
            txtIDNumber = new TextBox();
            dtpDOB = new DateTimePicker();
            txtSex = new TextBox();
            txtPlaceOfBirth = new TextBox();
            dtpDateOfIssue = new DateTimePicker();
            dtpDateOfExpiry = new DateTimePicker();
            txtIssuingAuthority = new TextBox();
            txtSignature = new TextBox();
            pbPhoto = new PictureBox();
            txtMRZ1 = new TextBox();
            txtMRZ2 = new TextBox();
            btnMRZ = new Button();
            btnPrint = new Button();
            btnNew = new Button();
            cmbDocType = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
            SuspendLayout();
            // 
            // cmbIssuingState
            // 
            cmbIssuingState.FormattingEnabled = true;
            cmbIssuingState.Location = new Point(93, 12);
            cmbIssuingState.Name = "cmbIssuingState";
            cmbIssuingState.Size = new Size(244, 33);
            cmbIssuingState.TabIndex = 0;
            cmbIssuingState.SelectedIndexChanged += cmbIssuingState_SelectedIndexChanged;
            // 
            // txtDocument
            // 
            txtDocument.Location = new Point(12, 64);
            txtDocument.Name = "txtDocument";
            txtDocument.Size = new Size(212, 31);
            txtDocument.TabIndex = 3;
            txtDocument.Text = "Passport";
            // 
            // txtType
            // 
            txtType.Location = new Point(230, 64);
            txtType.Name = "txtType";
            txtType.Size = new Size(107, 31);
            txtType.TabIndex = 4;
            txtType.Text = "Type";
            // 
            // txtStateCode
            // 
            txtStateCode.Location = new Point(343, 64);
            txtStateCode.Name = "txtStateCode";
            txtStateCode.Size = new Size(107, 31);
            txtStateCode.TabIndex = 5;
            txtStateCode.Text = "State";
            // 
            // txtDocNumber
            // 
            txtDocNumber.Location = new Point(456, 64);
            txtDocNumber.Name = "txtDocNumber";
            txtDocNumber.Size = new Size(261, 31);
            txtDocNumber.TabIndex = 6;
            txtDocNumber.Text = "DocNumber";
            txtDocNumber.TextChanged += txtDocNumber_TextChanged;
            txtDocNumber.KeyPress += txtDocNumber_KeyPress;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(253, 113);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(464, 31);
            txtSurname.TabIndex = 7;
            txtSurname.Text = "Surname";
            txtSurname.TextChanged += txtSurname_TextChanged;
            txtSurname.KeyPress += txtSurname_KeyPress;
            // 
            // txtOtherNames
            // 
            txtOtherNames.Location = new Point(253, 163);
            txtOtherNames.Name = "txtOtherNames";
            txtOtherNames.Size = new Size(464, 31);
            txtOtherNames.TabIndex = 8;
            txtOtherNames.Text = "OtherNames";
            txtOtherNames.TextChanged += txtOtherNames_TextChanged;
            txtOtherNames.KeyPress += txtOtherNames_KeyPress;
            // 
            // txtNationality
            // 
            txtNationality.Location = new Point(253, 213);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(464, 31);
            txtNationality.TabIndex = 9;
            txtNationality.Text = "Nationality";
            txtNationality.TextChanged += txtNationality_TextChanged;
            // 
            // txtIDNumber
            // 
            txtIDNumber.Location = new Point(479, 262);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(238, 31);
            txtIDNumber.TabIndex = 10;
            txtIDNumber.Text = "IDNumber";
            txtIDNumber.TextChanged += txtIDNumber_TextChanged;
            txtIDNumber.KeyPress += txtIDNumber_KeyPress;
            // 
            // dtpDOB
            // 
            dtpDOB.CustomFormat = "dd-MMM-yyyy";
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.Location = new Point(253, 262);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(220, 31);
            dtpDOB.TabIndex = 11;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(253, 311);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(107, 31);
            txtSex.TabIndex = 12;
            txtSex.Text = "Sex";
            txtSex.TextChanged += txtSex_TextChanged;
            // 
            // txtPlaceOfBirth
            // 
            txtPlaceOfBirth.Location = new Point(366, 311);
            txtPlaceOfBirth.Name = "txtPlaceOfBirth";
            txtPlaceOfBirth.Size = new Size(351, 31);
            txtPlaceOfBirth.TabIndex = 13;
            txtPlaceOfBirth.Text = "PlaceOfBirth";
            txtPlaceOfBirth.TextChanged += txtPlaceOfBirth_TextChanged;
            txtPlaceOfBirth.KeyPress += txtPlaceOfBirth_KeyPress;
            // 
            // dtpDateOfIssue
            // 
            dtpDateOfIssue.CustomFormat = "dd-MMM-yyyy";
            dtpDateOfIssue.Format = DateTimePickerFormat.Custom;
            dtpDateOfIssue.Location = new Point(253, 359);
            dtpDateOfIssue.Name = "dtpDateOfIssue";
            dtpDateOfIssue.Size = new Size(220, 31);
            dtpDateOfIssue.TabIndex = 14;
            // 
            // dtpDateOfExpiry
            // 
            dtpDateOfExpiry.CustomFormat = "dd-MMM-yyyy";
            dtpDateOfExpiry.Format = DateTimePickerFormat.Custom;
            dtpDateOfExpiry.Location = new Point(253, 407);
            dtpDateOfExpiry.Name = "dtpDateOfExpiry";
            dtpDateOfExpiry.Size = new Size(220, 31);
            dtpDateOfExpiry.TabIndex = 15;
            // 
            // txtIssuingAuthority
            // 
            txtIssuingAuthority.Location = new Point(479, 359);
            txtIssuingAuthority.Name = "txtIssuingAuthority";
            txtIssuingAuthority.Size = new Size(238, 31);
            txtIssuingAuthority.TabIndex = 16;
            txtIssuingAuthority.Text = "IssuingAuthority";
            // 
            // txtSignature
            // 
            txtSignature.Font = new Font("Edwardian Script ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSignature.Location = new Point(479, 407);
            txtSignature.Name = "txtSignature";
            txtSignature.Size = new Size(238, 29);
            txtSignature.TabIndex = 17;
            txtSignature.Text = "Signature";
            // 
            // pbPhoto
            // 
            pbPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbPhoto.InitialImage = null;
            pbPhoto.Location = new Point(12, 113);
            pbPhoto.Name = "pbPhoto";
            pbPhoto.Size = new Size(230, 312);
            pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPhoto.TabIndex = 18;
            pbPhoto.TabStop = false;
            pbPhoto.DoubleClick += pbPhoto_DoubleClick;
            // 
            // txtMRZ1
            // 
            txtMRZ1.Font = new Font("OCR B MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMRZ1.Location = new Point(12, 466);
            txtMRZ1.Name = "txtMRZ1";
            txtMRZ1.Size = new Size(705, 24);
            txtMRZ1.TabIndex = 19;
            txtMRZ1.Text = "MRZ1";
            // 
            // txtMRZ2
            // 
            txtMRZ2.Font = new Font("OCR B MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMRZ2.Location = new Point(12, 505);
            txtMRZ2.Name = "txtMRZ2";
            txtMRZ2.Size = new Size(705, 24);
            txtMRZ2.TabIndex = 20;
            txtMRZ2.Text = "MRZ2";
            // 
            // btnMRZ
            // 
            btnMRZ.BackgroundImageLayout = ImageLayout.Stretch;
            btnMRZ.FlatStyle = FlatStyle.System;
            btnMRZ.Font = new Font("Wingdings 2", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnMRZ.Location = new Point(737, 354);
            btnMRZ.Name = "btnMRZ";
            btnMRZ.Size = new Size(89, 84);
            btnMRZ.TabIndex = 21;
            btnMRZ.Text = "N";
            btnMRZ.UseVisualStyleBackColor = true;
            btnMRZ.Click += btnMRZ_Click;
            // 
            // btnPrint
            // 
            btnPrint.FlatStyle = FlatStyle.System;
            btnPrint.Font = new Font("Wingdings 2", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.Location = new Point(737, 452);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(89, 84);
            btnPrint.TabIndex = 22;
            btnPrint.Text = "6";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnNew
            // 
            btnNew.BackgroundImageLayout = ImageLayout.Stretch;
            btnNew.FlatStyle = FlatStyle.System;
            btnNew.Font = new Font("Wingdings 2", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(737, 258);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(89, 84);
            btnNew.TabIndex = 23;
            btnNew.Text = "/";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // cmbDocType
            // 
            cmbDocType.FormattingEnabled = true;
            cmbDocType.Location = new Point(491, 12);
            cmbDocType.Name = "cmbDocType";
            cmbDocType.Size = new Size(226, 33);
            cmbDocType.TabIndex = 24;
            cmbDocType.SelectedIndexChanged += cmbDocType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 25;
            label1.Text = "Country *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(402, 20);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 26;
            label2.Text = "Doc Type *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 55);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 27;
            label3.Text = "Document";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(230, 55);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 28;
            label4.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(343, 55);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 29;
            label5.Text = "State";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(456, 55);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 30;
            label6.Text = "PP Number *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 104);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 31;
            label7.Text = "Photo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(253, 104);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 32;
            label8.Text = "Surname *";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(253, 154);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 33;
            label9.Text = "Given Names";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(253, 203);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 34;
            label10.Text = "Nationality";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(253, 256);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 35;
            label11.Text = "DOB *";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(480, 256);
            label12.Name = "label12";
            label12.Size = new Size(65, 15);
            label12.TabIndex = 36;
            label12.Text = "ID Number";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(253, 303);
            label13.Name = "label13";
            label13.Size = new Size(53, 15);
            label13.TabIndex = 37;
            label13.Text = "Gender *";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(366, 303);
            label14.Name = "label14";
            label14.Size = new Size(85, 15);
            label14.TabIndex = 38;
            label14.Text = "Place of Birth *";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(253, 351);
            label15.Name = "label15";
            label15.Size = new Size(68, 15);
            label15.TabIndex = 39;
            label15.Text = "Issue Date *";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(253, 399);
            label16.Name = "label16";
            label16.Size = new Size(74, 15);
            label16.TabIndex = 40;
            label16.Text = "Expiry Date *";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(480, 351);
            label17.Name = "label17";
            label17.Size = new Size(97, 15);
            label17.TabIndex = 41;
            label17.Text = "Issuing Authotity";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(480, 399);
            label18.Name = "label18";
            label18.Size = new Size(57, 15);
            label18.TabIndex = 42;
            label18.Text = "Signature";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(12, 453);
            label19.Name = "label19";
            label19.Size = new Size(41, 15);
            label19.TabIndex = 43;
            label19.Text = "MRZ 1";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(10, 493);
            label20.Name = "label20";
            label20.Size = new Size(41, 15);
            label20.TabIndex = 44;
            label20.Text = "MRZ 2";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 560);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbDocType);
            Controls.Add(btnNew);
            Controls.Add(btnPrint);
            Controls.Add(btnMRZ);
            Controls.Add(txtMRZ2);
            Controls.Add(txtMRZ1);
            Controls.Add(pbPhoto);
            Controls.Add(txtSignature);
            Controls.Add(txtIssuingAuthority);
            Controls.Add(dtpDateOfExpiry);
            Controls.Add(dtpDateOfIssue);
            Controls.Add(txtPlaceOfBirth);
            Controls.Add(txtSex);
            Controls.Add(dtpDOB);
            Controls.Add(txtIDNumber);
            Controls.Add(txtNationality);
            Controls.Add(txtOtherNames);
            Controls.Add(txtSurname);
            Controls.Add(txtDocNumber);
            Controls.Add(txtStateCode);
            Controls.Add(txtType);
            Controls.Add(txtDocument);
            Controls.Add(cmbIssuingState);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "mainForm";
            Text = "TravDocGen v1.0";
            FormClosing += mainForm_FormClosing;
            FormClosed += mainForm_FormClosed;
            Load += mainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbIssuingState;
        private TextBox txtDocument;
        private TextBox txtType;
        private TextBox txtStateCode;
        private TextBox txtDocNumber;
        private TextBox txtSurname;
        private TextBox txtOtherNames;
        private TextBox txtNationality;
        private TextBox txtIDNumber;
        private DateTimePicker dtpDOB;
        private TextBox txtSex;
        private TextBox txtPlaceOfBirth;
        private DateTimePicker dtpDateOfIssue;
        private DateTimePicker dtpDateOfExpiry;
        private TextBox txtIssuingAuthority;
        private TextBox txtSignature;
        private PictureBox pbPhoto;
        private TextBox txtMRZ1;
        private TextBox txtMRZ2;
        private Button btnMRZ;
        private Button btnPrint;
        private Button btnNew;
        private ComboBox cmbDocType;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private ToolTip toolTip;
    }
}
