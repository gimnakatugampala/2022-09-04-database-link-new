
namespace _2022_09_04_database_link_new
{
    partial class Home
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
            this.btn_registration = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_ClientReport = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_ReportbyID = new System.Windows.Forms.Button();
            this.btn_ReportbyDOB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_registration
            // 
            this.btn_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registration.Location = new System.Drawing.Point(90, 64);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(140, 41);
            this.btn_registration.TabIndex = 0;
            this.btn_registration.Text = "Registration";
            this.btn_registration.UseVisualStyleBackColor = true;
            this.btn_registration.Click += new System.EventHandler(this.btn_registration_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(90, 156);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(140, 38);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete Client";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_ClientReport
            // 
            this.btn_ClientReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClientReport.Location = new System.Drawing.Point(90, 275);
            this.btn_ClientReport.Name = "btn_ClientReport";
            this.btn_ClientReport.Size = new System.Drawing.Size(140, 38);
            this.btn_ClientReport.TabIndex = 2;
            this.btn_ClientReport.Text = "Client Report";
            this.btn_ClientReport.UseVisualStyleBackColor = true;
            this.btn_ClientReport.Click += new System.EventHandler(this.btn_ClientReport_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(370, 64);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(137, 41);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update Client";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_display
            // 
            this.btn_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display.Location = new System.Drawing.Point(370, 156);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(137, 38);
            this.btn_display.TabIndex = 4;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // btn_ReportbyID
            // 
            this.btn_ReportbyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReportbyID.Location = new System.Drawing.Point(370, 275);
            this.btn_ReportbyID.Name = "btn_ReportbyID";
            this.btn_ReportbyID.Size = new System.Drawing.Size(137, 52);
            this.btn_ReportbyID.TabIndex = 5;
            this.btn_ReportbyID.Text = "Client Report by ID";
            this.btn_ReportbyID.UseVisualStyleBackColor = true;
            this.btn_ReportbyID.Click += new System.EventHandler(this.btn_ReportbyID_Click);
            // 
            // btn_ReportbyDOB
            // 
            this.btn_ReportbyDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReportbyDOB.Location = new System.Drawing.Point(221, 382);
            this.btn_ReportbyDOB.Name = "btn_ReportbyDOB";
            this.btn_ReportbyDOB.Size = new System.Drawing.Size(178, 56);
            this.btn_ReportbyDOB.TabIndex = 6;
            this.btn_ReportbyDOB.Text = "Client Report by DOB";
            this.btn_ReportbyDOB.UseVisualStyleBackColor = true;
            this.btn_ReportbyDOB.Click += new System.EventHandler(this.btn_ReportbyDOB_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ReportbyDOB);
            this.Controls.Add(this.btn_ReportbyID);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_ClientReport);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_registration);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_ClientReport;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Button btn_ReportbyID;
        private System.Windows.Forms.Button btn_ReportbyDOB;
    }
}

