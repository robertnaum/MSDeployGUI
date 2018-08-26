namespace MSDeployGUI
{
    partial class EditProfile
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ServerTxt = new System.Windows.Forms.TextBox();
            this.ServerLbl = new System.Windows.Forms.Label();
            this.SiteNameLbl = new System.Windows.Forms.Label();
            this.SiteNameTxt = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.DestinationURL = new System.Windows.Forms.TextBox();
            this.DestinationLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ValidateConnectionBtn = new System.Windows.Forms.Button();
            this.ConnectionStatusTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(645, 294);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(88, 32);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ServerTxt
            // 
            this.ServerTxt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerTxt.Location = new System.Drawing.Point(180, 58);
            this.ServerTxt.MaxLength = 256;
            this.ServerTxt.Name = "ServerTxt";
            this.ServerTxt.Size = new System.Drawing.Size(553, 27);
            this.ServerTxt.TabIndex = 2;
            // 
            // ServerLbl
            // 
            this.ServerLbl.AutoSize = true;
            this.ServerLbl.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerLbl.Location = new System.Drawing.Point(6, 61);
            this.ServerLbl.Name = "ServerLbl";
            this.ServerLbl.Size = new System.Drawing.Size(72, 20);
            this.ServerLbl.TabIndex = 11;
            this.ServerLbl.Text = "Server:";
            // 
            // SiteNameLbl
            // 
            this.SiteNameLbl.AutoSize = true;
            this.SiteNameLbl.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteNameLbl.Location = new System.Drawing.Point(6, 104);
            this.SiteNameLbl.Name = "SiteNameLbl";
            this.SiteNameLbl.Size = new System.Drawing.Size(99, 20);
            this.SiteNameLbl.TabIndex = 12;
            this.SiteNameLbl.Text = "Site name:";
            // 
            // SiteNameTxt
            // 
            this.SiteNameTxt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteNameTxt.Location = new System.Drawing.Point(180, 101);
            this.SiteNameTxt.MaxLength = 256;
            this.SiteNameTxt.Name = "SiteNameTxt";
            this.SiteNameTxt.Size = new System.Drawing.Size(553, 27);
            this.SiteNameTxt.TabIndex = 3;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(6, 19);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(54, 20);
            this.NameLbl.TabIndex = 10;
            this.NameLbl.Text = "Name:";
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(180, 16);
            this.NameTxt.MaxLength = 50;
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(220, 27);
            this.NameTxt.TabIndex = 1;
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl.Location = new System.Drawing.Point(6, 150);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(99, 20);
            this.UserNameLbl.TabIndex = 13;
            this.UserNameLbl.Text = "User name:";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxt.Location = new System.Drawing.Point(180, 147);
            this.UserNameTxt.MaxLength = 256;
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(220, 27);
            this.UserNameTxt.TabIndex = 4;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(180, 192);
            this.PasswordTxt.MaxLength = 256;
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(220, 27);
            this.PasswordTxt.TabIndex = 5;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(6, 196);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(90, 20);
            this.PasswordLbl.TabIndex = 14;
            this.PasswordLbl.Text = "Password:";
            // 
            // DestinationURL
            // 
            this.DestinationURL.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationURL.Location = new System.Drawing.Point(180, 236);
            this.DestinationURL.MaxLength = 256;
            this.DestinationURL.Name = "DestinationURL";
            this.DestinationURL.Size = new System.Drawing.Size(553, 27);
            this.DestinationURL.TabIndex = 6;
            // 
            // DestinationLbl
            // 
            this.DestinationLbl.AutoSize = true;
            this.DestinationLbl.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLbl.Location = new System.Drawing.Point(6, 240);
            this.DestinationLbl.Name = "DestinationLbl";
            this.DestinationLbl.Size = new System.Drawing.Size(153, 20);
            this.DestinationLbl.TabIndex = 15;
            this.DestinationLbl.Text = "Destination URL:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(535, 294);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(88, 32);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ValidateConnectionBtn
            // 
            this.ValidateConnectionBtn.Location = new System.Drawing.Point(12, 294);
            this.ValidateConnectionBtn.Name = "ValidateConnectionBtn";
            this.ValidateConnectionBtn.Size = new System.Drawing.Size(201, 32);
            this.ValidateConnectionBtn.TabIndex = 7;
            this.ValidateConnectionBtn.Text = "Validate Connection";
            this.ValidateConnectionBtn.UseVisualStyleBackColor = true;
            // 
            // ConnectionStatusTxt
            // 
            this.ConnectionStatusTxt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionStatusTxt.Location = new System.Drawing.Point(220, 299);
            this.ConnectionStatusTxt.Name = "ConnectionStatusTxt";
            this.ConnectionStatusTxt.Size = new System.Drawing.Size(68, 27);
            this.ConnectionStatusTxt.TabIndex = 15;
            this.ConnectionStatusTxt.TabStop = false;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 333);
            this.Controls.Add(this.ConnectionStatusTxt);
            this.Controls.Add(this.ValidateConnectionBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DestinationURL);
            this.Controls.Add(this.DestinationLbl);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.SiteNameTxt);
            this.Controls.Add(this.SiteNameLbl);
            this.Controls.Add(this.ServerLbl);
            this.Controls.Add(this.ServerTxt);
            this.Controls.Add(this.CancelBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProfile";
            this.Text = "Edit Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox ServerTxt;
        private System.Windows.Forms.Label ServerLbl;
        private System.Windows.Forms.Label SiteNameLbl;
        private System.Windows.Forms.TextBox SiteNameTxt;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox DestinationURL;
        private System.Windows.Forms.Label DestinationLbl;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ValidateConnectionBtn;
        private System.Windows.Forms.TextBox ConnectionStatusTxt;
    }
}