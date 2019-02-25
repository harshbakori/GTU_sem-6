namespace form_application
{
    partial class Form1
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
            this.lb_fname = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.bt_cancle = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_fname
            // 
            this.lb_fname.AutoSize = true;
            this.lb_fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_fname.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fname.Location = new System.Drawing.Point(174, 21);
            this.lb_fname.Name = "lb_fname";
            this.lb_fname.Size = new System.Drawing.Size(190, 31);
            this.lb_fname.TabIndex = 0;
            this.lb_fname.Tag = "Input Login form";
            this.lb_fname.Text = "Input Login form";
            this.lb_fname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_name
            // 
            this.lb_name.AllowDrop = true;
            this.lb_name.AutoSize = true;
            this.lb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(72, 101);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(76, 31);
            this.lb_name.TabIndex = 3;
            this.lb_name.Tag = "Name";
            this.lb_name.Text = "Name";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.Location = new System.Drawing.Point(72, 159);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(115, 31);
            this.lb_pass.TabIndex = 4;
            this.lb_pass.Tag = "Password";
            this.lb_pass.Text = "Password";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(306, 112);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(181, 20);
            this.txt_name.TabIndex = 0;
            this.txt_name.Tag = "Enter Name";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(306, 165);
            this.txt_pass.MaxLength = 16;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(181, 20);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.Tag = "Enter Password";
            // 
            // bt_cancle
            // 
            this.bt_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cancle.Location = new System.Drawing.Point(289, 230);
            this.bt_cancle.Name = "bt_cancle";
            this.bt_cancle.Size = new System.Drawing.Size(75, 23);
            this.bt_cancle.TabIndex = 4;
            this.bt_cancle.Tag = "Cancle";
            this.bt_cancle.Text = "Cancle";
            this.bt_cancle.UseVisualStyleBackColor = true;
            this.bt_cancle.Click += new System.EventHandler(this.bt_cancle_Click);
            // 
            // bt_next
            // 
            this.bt_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_next.Location = new System.Drawing.Point(174, 230);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(75, 23);
            this.bt_next.TabIndex = 3;
            this.bt_next.Text = "Login";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::form_application.Properties.Resources.the_division_load_screen_wallpaper_4k_by_valencygraphics_d9s8tgz;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 289);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.bt_cancle);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_fname);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form for test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_fname;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button bt_cancle;
        private System.Windows.Forms.Button bt_next;
    }
}

