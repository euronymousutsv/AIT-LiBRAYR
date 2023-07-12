namespace AITLibrary
{
    partial class adminForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.manageMediaBtn = new System.Windows.Forms.Button();
            this.manageStudentBtn = new System.Windows.Forms.Button();
            this.activityBtn = new System.Windows.Forms.Button();
            this.reportManageBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.reportManageBtn);
            this.panel1.Controls.Add(this.activityBtn);
            this.panel1.Controls.Add(this.manageStudentBtn);
            this.panel1.Controls.Add(this.manageMediaBtn);
            this.panel1.Location = new System.Drawing.Point(78, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 328);
            this.panel1.TabIndex = 0;
            // 
            // manageMediaBtn
            // 
            this.manageMediaBtn.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageMediaBtn.Location = new System.Drawing.Point(135, 44);
            this.manageMediaBtn.Name = "manageMediaBtn";
            this.manageMediaBtn.Size = new System.Drawing.Size(373, 47);
            this.manageMediaBtn.TabIndex = 0;
            this.manageMediaBtn.Text = "Manage Media";
            this.manageMediaBtn.UseVisualStyleBackColor = true;
            // 
            // manageStudentBtn
            // 
            this.manageStudentBtn.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageStudentBtn.Location = new System.Drawing.Point(135, 102);
            this.manageStudentBtn.Name = "manageStudentBtn";
            this.manageStudentBtn.Size = new System.Drawing.Size(373, 44);
            this.manageStudentBtn.TabIndex = 1;
            this.manageStudentBtn.Text = "Manage Student";
            this.manageStudentBtn.UseVisualStyleBackColor = true;
            // 
            // activityBtn
            // 
            this.activityBtn.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityBtn.Location = new System.Drawing.Point(135, 161);
            this.activityBtn.Name = "activityBtn";
            this.activityBtn.Size = new System.Drawing.Size(373, 45);
            this.activityBtn.TabIndex = 2;
            this.activityBtn.Text = "View Activities";
            this.activityBtn.UseVisualStyleBackColor = true;
            // 
            // reportManageBtn
            // 
            this.reportManageBtn.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportManageBtn.Location = new System.Drawing.Point(135, 223);
            this.reportManageBtn.Name = "reportManageBtn";
            this.reportManageBtn.Size = new System.Drawing.Size(373, 47);
            this.reportManageBtn.TabIndex = 3;
            this.reportManageBtn.Text = "Manage Report";
            this.reportManageBtn.UseVisualStyleBackColor = true;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button activityBtn;
        private System.Windows.Forms.Button manageStudentBtn;
        private System.Windows.Forms.Button manageMediaBtn;
        private System.Windows.Forms.Button reportManageBtn;
    }
}