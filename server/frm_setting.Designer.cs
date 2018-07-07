namespace server
{
    partial class frm_setting
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
            this.btnok = new System.Windows.Forms.Button();
            this.txtrecport = new System.Windows.Forms.TextBox();
            this.txtsendport = new System.Windows.Forms.TextBox();
            this.txtserverip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(92, 210);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 13;
            this.btnok.Text = "تایید";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtrecport
            // 
            this.txtrecport.Location = new System.Drawing.Point(54, 152);
            this.txtrecport.Name = "txtrecport";
            this.txtrecport.Size = new System.Drawing.Size(100, 20);
            this.txtrecport.TabIndex = 12;
            // 
            // txtsendport
            // 
            this.txtsendport.Location = new System.Drawing.Point(54, 89);
            this.txtsendport.Name = "txtsendport";
            this.txtsendport.Size = new System.Drawing.Size(100, 20);
            this.txtsendport.TabIndex = 11;
            // 
            // txtserverip
            // 
            this.txtserverip.Location = new System.Drawing.Point(54, 40);
            this.txtserverip.Name = "txtserverip";
            this.txtserverip.Size = new System.Drawing.Size(100, 20);
            this.txtserverip.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "پورت انتقال";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "پورت پیام";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "آدرس سرور";
            // 
            // frm_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtrecport);
            this.Controls.Add(this.txtsendport);
            this.Controls.Add(this.txtserverip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_setting";
            this.Text = "frm_setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtrecport;
        private System.Windows.Forms.TextBox txtsendport;
        private System.Windows.Forms.TextBox txtserverip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}