namespace Desctop_aplication
{
    partial class options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(options));
            this.lb_chack = new System.Windows.Forms.Label();
            this.lb_add = new System.Windows.Forms.Label();
            this.lb_pay = new System.Windows.Forms.Label();
            this.checkbal = new System.Windows.Forms.Button();
            this.addbal = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_chack
            // 
            this.lb_chack.AutoSize = true;
            this.lb_chack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chack.Location = new System.Drawing.Point(179, 91);
            this.lb_chack.Name = "lb_chack";
            this.lb_chack.Size = new System.Drawing.Size(122, 20);
            this.lb_chack.TabIndex = 6;
            this.lb_chack.Text = "check ballance :";
            this.lb_chack.Click += new System.EventHandler(this.lb_chack_Click);
            // 
            // lb_add
            // 
            this.lb_add.AutoSize = true;
            this.lb_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_add.Location = new System.Drawing.Point(179, 152);
            this.lb_add.Name = "lb_add";
            this.lb_add.Size = new System.Drawing.Size(97, 20);
            this.lb_add.TabIndex = 7;
            this.lb_add.Text = "Add money :";
            // 
            // lb_pay
            // 
            this.lb_pay.AutoSize = true;
            this.lb_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pay.Location = new System.Drawing.Point(179, 209);
            this.lb_pay.Name = "lb_pay";
            this.lb_pay.Size = new System.Drawing.Size(94, 20);
            this.lb_pay.TabIndex = 8;
            this.lb_pay.Text = "Pay money :";
            // 
            // checkbal
            // 
            this.checkbal.Location = new System.Drawing.Point(431, 91);
            this.checkbal.Name = "checkbal";
            this.checkbal.Size = new System.Drawing.Size(162, 23);
            this.checkbal.TabIndex = 9;
            this.checkbal.Text = "click to check balance";
            this.checkbal.UseVisualStyleBackColor = true;
            this.checkbal.Click += new System.EventHandler(this.click_Click);
            // 
            // addbal
            // 
            this.addbal.Location = new System.Drawing.Point(431, 152);
            this.addbal.Name = "addbal";
            this.addbal.Size = new System.Drawing.Size(162, 23);
            this.addbal.TabIndex = 10;
            this.addbal.Text = "click to add money";
            this.addbal.UseVisualStyleBackColor = true;
            this.addbal.Click += new System.EventHandler(this.button2_Click);
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(431, 209);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(162, 23);
            this.pay.TabIndex = 11;
            this.pay.Text = "click to pay";
            this.pay.UseVisualStyleBackColor = true;
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(349, 275);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(75, 23);
            this.bt_logout.TabIndex = 12;
            this.bt_logout.Text = "Logout";
            this.bt_logout.UseVisualStyleBackColor = true;
            // 
            // options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.addbal);
            this.Controls.Add(this.checkbal);
            this.Controls.Add(this.lb_pay);
            this.Controls.Add(this.lb_add);
            this.Controls.Add(this.lb_chack);
            this.Name = "options";
            this.Text = "options";
            this.Load += new System.EventHandler(this.options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_add;
        private System.Windows.Forms.Label lb_pay;
        private System.Windows.Forms.Button checkbal;
        private System.Windows.Forms.Button addbal;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Label lb_chack;
    }
}