namespace server
{
    partial class pc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mn_shdesktop = new System.Windows.Forms.ToolStripMenuItem();
            this.پیاماتماموقتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پیاماختصاصیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcimg = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcimg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_shdesktop});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 48);
            // 
            // mn_shdesktop
            // 
            this.mn_shdesktop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.پیاماتماموقتToolStripMenuItem,
            this.پیاماختصاصیToolStripMenuItem});
            this.mn_shdesktop.Name = "mn_shdesktop";
            this.mn_shdesktop.Size = new System.Drawing.Size(157, 22);
            this.mn_shdesktop.Text = "مشاهده دسکتاپ";
            this.mn_shdesktop.Click += new System.EventHandler(this.mn_shdesktop_Click);
            // 
            // پیاماتماموقتToolStripMenuItem
            // 
            this.پیاماتماموقتToolStripMenuItem.Name = "پیاماتماموقتToolStripMenuItem";
            this.پیاماتماموقتToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.پیاماتماموقتToolStripMenuItem.Text = "پیام اتمام وقت";
            // 
            // پیاماختصاصیToolStripMenuItem
            // 
            this.پیاماختصاصیToolStripMenuItem.Name = "پیاماختصاصیToolStripMenuItem";
            this.پیاماختصاصیToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.پیاماختصاصیToolStripMenuItem.Text = "پیام اختصاصی";
            // 
            // pcimg
            // 
            this.pcimg.Image = global::server.Properties.Resources._1;
            this.pcimg.Location = new System.Drawing.Point(13, 6);
            this.pcimg.Name = "pcimg";
            this.pcimg.Size = new System.Drawing.Size(32, 32);
            this.pcimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcimg.TabIndex = 2;
            this.pcimg.TabStop = false;
            this.pcimg.Click += new System.EventHandler(this.pcimg_Click);
            this.pcimg.MouseEnter += new System.EventHandler(this.pcimg_MouseEnter);
            // 
            // pc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pcimg);
            this.Controls.Add(this.label1);
            this.Name = "pc";
            this.Size = new System.Drawing.Size(63, 62);
            this.Load += new System.EventHandler(this.pc_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mn_shdesktop;
        private System.Windows.Forms.ToolStripMenuItem پیاماتماموقتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem پیاماختصاصیToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcimg;
       
    }
}
