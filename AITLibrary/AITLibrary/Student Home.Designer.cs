namespace AITLibrary
{
    partial class StudentHome
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
            this.accountSettings = new System.Windows.Forms.Button();
            this.browseMedia = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.historyBtn);
            this.panel1.Controls.Add(this.accountSettings);
            this.panel1.Controls.Add(this.browseMedia);
            this.panel1.Location = new System.Drawing.Point(66, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 229);
            this.panel1.TabIndex = 0;
            // 
            // accountSettings
            // 
            this.accountSettings.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSettings.Location = new System.Drawing.Point(61, 86);
            this.accountSettings.Name = "accountSettings";
            this.accountSettings.Size = new System.Drawing.Size(331, 50);
            this.accountSettings.TabIndex = 1;
            this.accountSettings.Text = "Account Settings";
            this.accountSettings.UseVisualStyleBackColor = true;
            // 
            // browseMedia
            // 
            this.browseMedia.AutoEllipsis = true;
            this.browseMedia.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseMedia.Location = new System.Drawing.Point(61, 20);
            this.browseMedia.Name = "browseMedia";
            this.browseMedia.Size = new System.Drawing.Size(331, 43);
            this.browseMedia.TabIndex = 0;
            this.browseMedia.Text = "Browse Media";
            this.browseMedia.UseVisualStyleBackColor = true;
            this.browseMedia.Click += new System.EventHandler(this.browseMedia_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyBtn.Location = new System.Drawing.Point(61, 154);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(331, 44);
            this.historyBtn.TabIndex = 2;
            this.historyBtn.Text = "History";
            this.historyBtn.UseVisualStyleBackColor = true;
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentHome";
            this.Text = "Student Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button accountSettings;
        private System.Windows.Forms.Button browseMedia;
        private System.Windows.Forms.Button historyBtn;
    }
}