namespace Assignment
{
    partial class Receipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblClinicName = new System.Windows.Forms.Label();
            this.lblAmountValue = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPatientValues = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblAppointmentTimeValue = new System.Windows.Forms.Label();
            this.lblAppointmentTime = new System.Windows.Forms.Label();
            this.lblAppointmentDateValue = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.lblClinicContact = new System.Windows.Forms.Label();
            this.lblClinicAddress = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printdoc1 = new System.Drawing.Printing.PrintDocument();
            this.previewdlg = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDoctorName);
            this.panel1.Controls.Add(this.lblClinicName);
            this.panel1.Controls.Add(this.lblAmountValue);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.lblPatientValues);
            this.panel1.Controls.Add(this.lblPatient);
            this.panel1.Controls.Add(this.lblAppointmentTimeValue);
            this.panel1.Controls.Add(this.lblAppointmentTime);
            this.panel1.Controls.Add(this.lblAppointmentDateValue);
            this.panel1.Controls.Add(this.lblAppointmentDate);
            this.panel1.Controls.Add(this.lblClinicContact);
            this.panel1.Controls.Add(this.lblClinicAddress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 476);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(442, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment Receipt";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(31, 88);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(125, 28);
            this.lblDoctorName.TabIndex = 13;
            this.lblDoctorName.Text = "DoctorName";
            // 
            // lblClinicName
            // 
            this.lblClinicName.AutoSize = true;
            this.lblClinicName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinicName.Location = new System.Drawing.Point(30, 123);
            this.lblClinicName.Name = "lblClinicName";
            this.lblClinicName.Size = new System.Drawing.Size(111, 28);
            this.lblClinicName.TabIndex = 12;
            this.lblClinicName.Text = "ClinicName";
            // 
            // lblAmountValue
            // 
            this.lblAmountValue.AutoSize = true;
            this.lblAmountValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountValue.Location = new System.Drawing.Point(215, 415);
            this.lblAmountValue.Name = "lblAmountValue";
            this.lblAmountValue.Size = new System.Drawing.Size(70, 28);
            this.lblAmountValue.TabIndex = 11;
            this.lblAmountValue.Text = "label2";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(30, 416);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(154, 28);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Toatal amount:";
            // 
            // lblPatientValues
            // 
            this.lblPatientValues.AutoSize = true;
            this.lblPatientValues.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientValues.Location = new System.Drawing.Point(215, 245);
            this.lblPatientValues.Name = "lblPatientValues";
            this.lblPatientValues.Size = new System.Drawing.Size(65, 28);
            this.lblPatientValues.TabIndex = 9;
            this.lblPatientValues.Text = "label2";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.Location = new System.Drawing.Point(30, 246);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(72, 28);
            this.lblPatient.TabIndex = 8;
            this.lblPatient.Text = "Patient";
            // 
            // lblAppointmentTimeValue
            // 
            this.lblAppointmentTimeValue.AutoSize = true;
            this.lblAppointmentTimeValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentTimeValue.Location = new System.Drawing.Point(216, 324);
            this.lblAppointmentTimeValue.Name = "lblAppointmentTimeValue";
            this.lblAppointmentTimeValue.Size = new System.Drawing.Size(65, 28);
            this.lblAppointmentTimeValue.TabIndex = 7;
            this.lblAppointmentTimeValue.Text = "label2";
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentTime.Location = new System.Drawing.Point(31, 325);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(203, 28);
            this.lblAppointmentTime.TabIndex = 6;
            this.lblAppointmentTime.Text = "Time of Appointment:";
            // 
            // lblAppointmentDateValue
            // 
            this.lblAppointmentDateValue.AutoSize = true;
            this.lblAppointmentDateValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDateValue.Location = new System.Drawing.Point(216, 286);
            this.lblAppointmentDateValue.Name = "lblAppointmentDateValue";
            this.lblAppointmentDateValue.Size = new System.Drawing.Size(65, 28);
            this.lblAppointmentDateValue.TabIndex = 5;
            this.lblAppointmentDateValue.Text = "label2";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.Location = new System.Drawing.Point(31, 287);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(202, 28);
            this.lblAppointmentDate.TabIndex = 4;
            this.lblAppointmentDate.Text = "Date of Appointment:";
            // 
            // lblClinicContact
            // 
            this.lblClinicContact.AutoSize = true;
            this.lblClinicContact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinicContact.Location = new System.Drawing.Point(30, 195);
            this.lblClinicContact.Name = "lblClinicContact";
            this.lblClinicContact.Size = new System.Drawing.Size(127, 28);
            this.lblClinicContact.TabIndex = 3;
            this.lblClinicContact.Text = "ClinicContact";
            // 
            // lblClinicAddress
            // 
            this.lblClinicAddress.AutoSize = true;
            this.lblClinicAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinicAddress.Location = new System.Drawing.Point(30, 156);
            this.lblClinicAddress.Name = "lblClinicAddress";
            this.lblClinicAddress.Size = new System.Drawing.Size(129, 28);
            this.lblClinicAddress.TabIndex = 1;
            this.lblClinicAddress.Text = "ClinicAddress";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(947, 553);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(129, 51);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printdoc1
            // 
            this.printdoc1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printdoc1_PrintPage);
            // 
            // previewdlg
            // 
            this.previewdlg.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.previewdlg.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.previewdlg.ClientSize = new System.Drawing.Size(400, 300);
            this.previewdlg.Enabled = true;
            this.previewdlg.Icon = ((System.Drawing.Icon)(resources.GetObject("previewdlg.Icon")));
            this.previewdlg.Name = "previewdlg";
            this.previewdlg.Visible = false;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrint);
            this.Name = "Receipt";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAmountValue;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPatientValues;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblAppointmentTimeValue;
        private System.Windows.Forms.Label lblAppointmentTime;
        private System.Windows.Forms.Label lblAppointmentDateValue;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblClinicContact;
        private System.Windows.Forms.Label lblClinicAddress;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClinicName;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Drawing.Printing.PrintDocument printdoc1;
        private System.Windows.Forms.PrintPreviewDialog previewdlg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}