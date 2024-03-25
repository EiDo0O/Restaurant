
namespace Restraurant_P_1
{
    partial class Registeration
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
            this.log_in = new System.Windows.Forms.Button();
            this.UserPW = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.Transparent;
            this.log_in.BackgroundImage = global::Restraurant_P_1.Properties.Resources.imagess;
            this.log_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.log_in.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.log_in.FlatAppearance.BorderSize = 0;
            this.log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_in.Location = new System.Drawing.Point(238, 218);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(77, 23);
            this.log_in.TabIndex = 9;
            this.log_in.UseVisualStyleBackColor = false;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // UserPW
            // 
            this.UserPW.Location = new System.Drawing.Point(144, 169);
            this.UserPW.Multiline = true;
            this.UserPW.Name = "UserPW";
            this.UserPW.Size = new System.Drawing.Size(255, 29);
            this.UserPW.TabIndex = 8;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(144, 109);
            this.UserName.Multiline = true;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(255, 29);
            this.UserName.TabIndex = 7;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Location = new System.Drawing.Point(449, 171);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(92, 27);
            this.password.TabIndex = 6;
            this.password.Text = "كلمة السر";
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.BackColor = System.Drawing.Color.Transparent;
            this.user_name.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user_name.Location = new System.Drawing.Point(439, 109);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(118, 27);
            this.user_name.TabIndex = 5;
            this.user_name.Text = "اسم المستخدم";
            // 
            // Registeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restraurant_P_1.Properties.Resources.e67daf68a6e8f6d4a9283cb7d64b098c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.UserPW);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_name);
            this.Name = "Registeration";
            this.Text = "Registeration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.TextBox UserPW;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label user_name;
    }
}