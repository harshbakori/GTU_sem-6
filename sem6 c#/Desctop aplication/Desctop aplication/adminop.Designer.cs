namespace Desctop_aplication
{
    partial class adminop
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
            this.addbal = new System.Windows.Forms.Button();
            this.checkbal = new System.Windows.Forms.Button();
            this.lb_add = new System.Windows.Forms.Label();
            this.lb_chack = new System.Windows.Forms.Label();
            this.bt_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addbal
            // 
            this.addbal.Location = new System.Drawing.Point(393, 244);
            this.addbal.Name = "addbal";
            this.addbal.Size = new System.Drawing.Size(162, 23);
            this.addbal.TabIndex = 14;
            this.addbal.Text = "click to add money";
            this.addbal.UseVisualStyleBackColor = true;
            this.addbal.Click += new System.EventHandler(this.addbal_Click);
            // 
            // checkbal
            // 
            this.checkbal.Location = new System.Drawing.Point(393, 158);
            this.checkbal.Name = "checkbal";
            this.checkbal.Size = new System.Drawing.Size(162, 23);
            this.checkbal.TabIndex = 13;
            this.checkbal.Text = "click to check balance";
            this.checkbal.UseVisualStyleBackColor = true;
            this.checkbal.Click += new System.EventHandler(this.checkbal_Click);
            // 
            // lb_add
            // 
            this.lb_add.AutoSize = true;
            this.lb_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_add.Location = new System.Drawing.Point(255, 247);
            this.lb_add.Name = "lb_add";
            this.lb_add.Size = new System.Drawing.Size(84, 20);
            this.lb_add.TabIndex = 12;
            this.lb_add.Text = "Add Users";
            this.lb_add.Click += new System.EventHandler(this.lb_add_Click);
            // 
            // lb_chack
            // 
            this.lb_chack.AutoSize = true;
            this.lb_chack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chack.Location = new System.Drawing.Point(255, 158);
            this.lb_chack.Name = "lb_chack";
            this.lb_chack.Size = new System.Drawing.Size(88, 20);
            this.lb_chack.TabIndex = 11;
            this.lb_chack.Text = "List Users :";
            this.lb_chack.Click += new System.EventHandler(this.lb_chack_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(369, 349);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(75, 23);
            this.bt_logout.TabIndex = 15;
            this.bt_logout.Text = "Logout";
            this.bt_logout.UseVisualStyleBackColor = true;
            // 
            // adminop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.addbal);
            this.Controls.Add(this.checkbal);
            this.Controls.Add(this.lb_add);
            this.Controls.Add(this.lb_chack);
            this.Name = "adminop";
            this.Text = "adminop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbal;
        private System.Windows.Forms.Button checkbal;
        private System.Windows.Forms.Label lb_add;
        private System.Windows.Forms.Label lb_chack;
        private System.Windows.Forms.Button bt_logout;
    }
}