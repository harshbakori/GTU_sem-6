namespace Desctop_aplication
{
    partial class pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pay));
            this.tb_contact = new System.Windows.Forms.TextBox();
            this.lb_contact = new System.Windows.Forms.Label();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.lb_amount = new System.Windows.Forms.Label();
            this.lb_cancle = new System.Windows.Forms.Button();
            this.bt_pay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_contact
            // 
            this.tb_contact.Location = new System.Drawing.Point(418, 105);
            this.tb_contact.Name = "tb_contact";
            this.tb_contact.Size = new System.Drawing.Size(141, 20);
            this.tb_contact.TabIndex = 6;
            this.tb_contact.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // lb_contact
            // 
            this.lb_contact.AutoSize = true;
            this.lb_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contact.Location = new System.Drawing.Point(251, 105);
            this.lb_contact.Name = "lb_contact";
            this.lb_contact.Size = new System.Drawing.Size(91, 20);
            this.lb_contact.TabIndex = 5;
            this.lb_contact.Text = "Contact no.";
            this.lb_contact.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // tb_amount
            // 
            this.tb_amount.Location = new System.Drawing.Point(418, 175);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(141, 20);
            this.tb_amount.TabIndex = 8;
            this.tb_amount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_amount.Location = new System.Drawing.Point(251, 175);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(112, 20);
            this.lb_amount.TabIndex = 7;
            this.lb_amount.Text = "Amount to pay";
            this.lb_amount.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_cancle
            // 
            this.lb_cancle.Location = new System.Drawing.Point(498, 244);
            this.lb_cancle.Name = "lb_cancle";
            this.lb_cancle.Size = new System.Drawing.Size(75, 23);
            this.lb_cancle.TabIndex = 16;
            this.lb_cancle.Text = "Cancle";
            this.lb_cancle.UseVisualStyleBackColor = true;
            // 
            // bt_pay
            // 
            this.bt_pay.Location = new System.Drawing.Point(297, 244);
            this.bt_pay.Name = "bt_pay";
            this.bt_pay.Size = new System.Drawing.Size(75, 23);
            this.bt_pay.TabIndex = 15;
            this.bt_pay.Text = "Pay";
            this.bt_pay.UseVisualStyleBackColor = true;
            // 
            // pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.ControlBox = false;
            this.Controls.Add(this.lb_cancle);
            this.Controls.Add(this.bt_pay);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.lb_amount);
            this.Controls.Add(this.tb_contact);
            this.Controls.Add(this.lb_contact);
            this.Name = "pay";
            this.Text = "pay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_contact;
        private System.Windows.Forms.Label lb_contact;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.Label lb_amount;
        private System.Windows.Forms.Button lb_cancle;
        private System.Windows.Forms.Button bt_pay;
    }
}