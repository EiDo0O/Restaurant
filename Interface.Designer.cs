
namespace Restraurant_P_1
{
    partial class Interface
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
            this.components = new System.ComponentModel.Container();
            this.chefs = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Food = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.user_name = new System.Windows.Forms.Label();
            this.Registeration = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // chefs
            // 
            this.chefs.AutoSize = true;
            this.chefs.BackColor = System.Drawing.Color.Transparent;
            this.chefs.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chefs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chefs.Location = new System.Drawing.Point(72, 232);
            this.chefs.Name = "chefs";
            this.chefs.Size = new System.Drawing.Size(49, 13);
            this.chefs.TabIndex = 14;
            this.chefs.Text = "طاقم العمل";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Restraurant_P_1.Properties.Resources.imagee;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(72, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 126);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Food
            // 
            this.Food.AutoSize = true;
            this.Food.BackColor = System.Drawing.Color.Transparent;
            this.Food.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Food.Location = new System.Drawing.Point(278, 232);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(31, 13);
            this.Food.TabIndex = 12;
            this.Food.Text = "الطعام";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Restraurant_P_1.Properties.Resources.imag;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(290, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 123);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.BackColor = System.Drawing.Color.Transparent;
            this.user_name.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user_name.Location = new System.Drawing.Point(505, 227);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(61, 13);
            this.user_name.TabIndex = 10;
            this.user_name.Text = "تسجيل الدخول";
            // 
            // Registeration
            // 
            this.Registeration.BackColor = System.Drawing.Color.Transparent;
            this.Registeration.BackgroundImage = global::Restraurant_P_1.Properties.Resources._6822308;
            this.Registeration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Registeration.FlatAppearance.BorderSize = 0;
            this.Registeration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registeration.Location = new System.Drawing.Point(495, 108);
            this.Registeration.Name = "Registeration";
            this.Registeration.Size = new System.Drawing.Size(137, 135);
            this.Registeration.TabIndex = 9;
            this.Registeration.UseVisualStyleBackColor = false;
            this.Registeration.Click += new System.EventHandler(this.Registeration_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restraurant_P_1.Properties.Resources.image_of_wooden_table_in_front_of_abstract_blurred_background_of_resturant_lights_wood_table_top_on_blur_of_lighting_in_night_cafe_restaurant_background_selective_focus_generative_ai_photo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.chefs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.Registeration);
            this.Name = "Interface";
            this.Text = "Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chefs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Food;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Button Registeration;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

