
namespace Restraurant_P_1
{
    partial class New_register
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
            this.UserEmail = new System.Windows.Forms.TextBox();
            this.UserPhoneNum = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.UserPhone = new System.Windows.Forms.Label();
            this.UserPW = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.log_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserEmail
            // 
            this.UserEmail.Location = new System.Drawing.Point(265, 233);
            this.UserEmail.Multiline = true;
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.Size = new System.Drawing.Size(255, 29);
            this.UserEmail.TabIndex = 21;
            // 
            // UserPhoneNum
            // 
            this.UserPhoneNum.Location = new System.Drawing.Point(265, 178);
            this.UserPhoneNum.Multiline = true;
            this.UserPhoneNum.Name = "UserPhoneNum";
            this.UserPhoneNum.Size = new System.Drawing.Size(255, 29);
            this.UserPhoneNum.TabIndex = 20;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.email.Location = new System.Drawing.Point(526, 233);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(146, 27);
            this.email.TabIndex = 19;
            this.email.Text = "البريد الإلكتروني";
            // 
            // UserPhone
            // 
            this.UserPhone.AutoSize = true;
            this.UserPhone.BackColor = System.Drawing.Color.Transparent;
            this.UserPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserPhone.Location = new System.Drawing.Point(565, 178);
            this.UserPhone.Name = "UserPhone";
            this.UserPhone.Size = new System.Drawing.Size(107, 27);
            this.UserPhone.TabIndex = 18;
            this.UserPhone.Text = "رقم التليفون";
            // 
            // UserPW
            // 
            this.UserPW.Location = new System.Drawing.Point(265, 119);
            this.UserPW.Multiline = true;
            this.UserPW.Name = "UserPW";
            this.UserPW.Size = new System.Drawing.Size(255, 29);
            this.UserPW.TabIndex = 17;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(265, 63);
            this.UserName.Multiline = true;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(255, 29);
            this.UserName.TabIndex = 16;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password.Location = new System.Drawing.Point(580, 119);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(92, 27);
            this.password.TabIndex = 15;
            this.password.Text = "كلمة السر";
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.BackColor = System.Drawing.Color.Transparent;
            this.user_name.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.user_name.Location = new System.Drawing.Point(554, 63);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(118, 27);
            this.user_name.TabIndex = 14;
            this.user_name.Text = "اسم المستخدم";
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.Transparent;
            this.log_in.BackgroundImage = global::Restraurant_P_1.Properties.Resources.imm;
            this.log_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.log_in.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.log_in.FlatAppearance.BorderSize = 0;
            this.log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_in.Location = new System.Drawing.Point(53, 96);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(149, 155);
            this.log_in.TabIndex = 22;
            this.log_in.UseVisualStyleBackColor = false;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // New_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restraurant_P_1.Properties.Resources.download12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.UserEmail);
            this.Controls.Add(this.UserPhoneNum);
            this.Controls.Add(this.email);
            this.Controls.Add(this.UserPhone);
            this.Controls.Add(this.UserPW);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_name);
            this.Name = "New_register";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserEmail;
        private System.Windows.Forms.TextBox UserPhoneNum;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label UserPhone;
        private System.Windows.Forms.TextBox UserPW;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Button log_in;
    }
}