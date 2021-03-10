namespace Assignment
{
    partial class DoctorDetails
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
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblDoctorSpeciality = new System.Windows.Forms.Label();
            this.lblDoctorContact = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.lblDoctorNameValue = new System.Windows.Forms.Label();
            this.lblDoctorSpecialityValue = new System.Windows.Forms.Label();
            this.lblDoctorContactValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.Location = new System.Drawing.Point(309, 95);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(168, 35);
            this.lblDoctor.TabIndex = 0;
            this.lblDoctor.Text = "Doctor\'s Name:";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(309, 177);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(168, 35);
            this.lblDoctorName.TabIndex = 1;
            this.lblDoctorName.Text = "Doctor\'s Name:";
            // 
            // lblDoctorSpeciality
            // 
            this.lblDoctorSpeciality.AutoSize = true;
            this.lblDoctorSpeciality.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorSpeciality.Location = new System.Drawing.Point(309, 237);
            this.lblDoctorSpeciality.Name = "lblDoctorSpeciality";
            this.lblDoctorSpeciality.Size = new System.Drawing.Size(206, 35);
            this.lblDoctorSpeciality.TabIndex = 2;
            this.lblDoctorSpeciality.Text = "Doctor\'s Speciality:";
            // 
            // lblDoctorContact
            // 
            this.lblDoctorContact.AutoSize = true;
            this.lblDoctorContact.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorContact.Location = new System.Drawing.Point(309, 298);
            this.lblDoctorContact.Name = "lblDoctorContact";
            this.lblDoctorContact.Size = new System.Drawing.Size(184, 35);
            this.lblDoctorContact.TabIndex = 3;
            this.lblDoctorContact.Text = "doctor\'s Contact:";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(550, 87);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(287, 43);
            this.cmbDoctor.TabIndex = 4;
            this.cmbDoctor.SelectedIndexChanged += new System.EventHandler(this.cmbDoctor_SelectedIndexChanged);
            // 
            // lblDoctorNameValue
            // 
            this.lblDoctorNameValue.AutoSize = true;
            this.lblDoctorNameValue.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorNameValue.Location = new System.Drawing.Point(546, 177);
            this.lblDoctorNameValue.Name = "lblDoctorNameValue";
            this.lblDoctorNameValue.Size = new System.Drawing.Size(0, 35);
            this.lblDoctorNameValue.TabIndex = 5;
            // 
            // lblDoctorSpecialityValue
            // 
            this.lblDoctorSpecialityValue.AutoSize = true;
            this.lblDoctorSpecialityValue.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorSpecialityValue.Location = new System.Drawing.Point(546, 233);
            this.lblDoctorSpecialityValue.Name = "lblDoctorSpecialityValue";
            this.lblDoctorSpecialityValue.Size = new System.Drawing.Size(0, 35);
            this.lblDoctorSpecialityValue.TabIndex = 6;
            // 
            // lblDoctorContactValue
            // 
            this.lblDoctorContactValue.AutoSize = true;
            this.lblDoctorContactValue.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorContactValue.Location = new System.Drawing.Point(546, 298);
            this.lblDoctorContactValue.Name = "lblDoctorContactValue";
            this.lblDoctorContactValue.Size = new System.Drawing.Size(0, 35);
            this.lblDoctorContactValue.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(514, 373);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 39);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DoctorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1126, 447);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDoctorContactValue);
            this.Controls.Add(this.lblDoctorSpecialityValue);
            this.Controls.Add(this.lblDoctorNameValue);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.lblDoctorContact);
            this.Controls.Add(this.lblDoctorSpeciality);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.lblDoctor);
            this.Name = "DoctorDetails";
            this.Text = "Doctor Details";
            this.Load += new System.EventHandler(this.DoctorDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblDoctorSpeciality;
        private System.Windows.Forms.Label lblDoctorContact;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label lblDoctorNameValue;
        private System.Windows.Forms.Label lblDoctorSpecialityValue;
        private System.Windows.Forms.Label lblDoctorContactValue;
        private System.Windows.Forms.Button btnClose;
    }
}