namespace Assignment
{
    partial class ShowMedicalHistory
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.lblPreviousDetails = new System.Windows.Forms.Label();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.lblCurrentDetails = new System.Windows.Forms.Label();
            this.lblInstruction3 = new System.Windows.Forms.Label();
            this.lblMedicationDetails = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(461, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Your Medical History";
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction1.Location = new System.Drawing.Point(259, 133);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(290, 35);
            this.lblInstruction1.TabIndex = 1;
            this.lblInstruction1.Text = "Previous Disease/s you had:";
            // 
            // lblPreviousDetails
            // 
            this.lblPreviousDetails.AutoSize = true;
            this.lblPreviousDetails.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousDetails.Location = new System.Drawing.Point(701, 133);
            this.lblPreviousDetails.Name = "lblPreviousDetails";
            this.lblPreviousDetails.Size = new System.Drawing.Size(76, 35);
            this.lblPreviousDetails.TabIndex = 2;
            this.lblPreviousDetails.Text = "label3";
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction2.Location = new System.Drawing.Point(259, 234);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(294, 35);
            this.lblInstruction2.TabIndex = 3;
            this.lblInstruction2.Text = "Current Disease/s you have:";
            // 
            // lblCurrentDetails
            // 
            this.lblCurrentDetails.AutoSize = true;
            this.lblCurrentDetails.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDetails.Location = new System.Drawing.Point(701, 234);
            this.lblCurrentDetails.Name = "lblCurrentDetails";
            this.lblCurrentDetails.Size = new System.Drawing.Size(76, 35);
            this.lblCurrentDetails.TabIndex = 4;
            this.lblCurrentDetails.Text = "label5";
            // 
            // lblInstruction3
            // 
            this.lblInstruction3.AutoSize = true;
            this.lblInstruction3.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction3.Location = new System.Drawing.Point(259, 338);
            this.lblInstruction3.Name = "lblInstruction3";
            this.lblInstruction3.Size = new System.Drawing.Size(396, 35);
            this.lblInstruction3.TabIndex = 5;
            this.lblInstruction3.Text = "Do you have any medication allergies:";
            // 
            // lblMedicationDetails
            // 
            this.lblMedicationDetails.AutoSize = true;
            this.lblMedicationDetails.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicationDetails.Location = new System.Drawing.Point(701, 338);
            this.lblMedicationDetails.Name = "lblMedicationDetails";
            this.lblMedicationDetails.Size = new System.Drawing.Size(76, 35);
            this.lblMedicationDetails.TabIndex = 6;
            this.lblMedicationDetails.Text = "label7";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(493, 482);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 56);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ShowMedicalHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1104, 634);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMedicationDetails);
            this.Controls.Add(this.lblInstruction3);
            this.Controls.Add(this.lblCurrentDetails);
            this.Controls.Add(this.lblInstruction2);
            this.Controls.Add(this.lblPreviousDetails);
            this.Controls.Add(this.lblInstruction1);
            this.Controls.Add(this.lblTitle);
            this.Name = "ShowMedicalHistory";
            this.Text = "Show Medical History";
            this.Load += new System.EventHandler(this.ShowMedicalHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Label lblPreviousDetails;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.Label lblCurrentDetails;
        private System.Windows.Forms.Label lblInstruction3;
        private System.Windows.Forms.Label lblMedicationDetails;
        private System.Windows.Forms.Button btnClose;
    }
}