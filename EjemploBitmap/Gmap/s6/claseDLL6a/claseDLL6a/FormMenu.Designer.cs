namespace claseDLL6a
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pREGUNTA1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pREGUNTA1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pREGUNTA2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pREGUNTA3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pREGUNTA1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(466, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pREGUNTA1ToolStripMenuItem
            // 
            this.pREGUNTA1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pREGUNTA1ToolStripMenuItem1,
            this.pREGUNTA2ToolStripMenuItem,
            this.pREGUNTA3ToolStripMenuItem});
            this.pREGUNTA1ToolStripMenuItem.Name = "pREGUNTA1ToolStripMenuItem";
            this.pREGUNTA1ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.pREGUNTA1ToolStripMenuItem.Text = "PRACTICA";
            // 
            // pREGUNTA1ToolStripMenuItem1
            // 
            this.pREGUNTA1ToolStripMenuItem1.Name = "pREGUNTA1ToolStripMenuItem1";
            this.pREGUNTA1ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pREGUNTA1ToolStripMenuItem1.Text = "PREGUNTA1";
            this.pREGUNTA1ToolStripMenuItem1.Click += new System.EventHandler(this.pREGUNTA1ToolStripMenuItem1_Click);
            // 
            // pREGUNTA2ToolStripMenuItem
            // 
            this.pREGUNTA2ToolStripMenuItem.Name = "pREGUNTA2ToolStripMenuItem";
            this.pREGUNTA2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pREGUNTA2ToolStripMenuItem.Text = "PREGUNTA2";
            this.pREGUNTA2ToolStripMenuItem.Click += new System.EventHandler(this.pREGUNTA2ToolStripMenuItem_Click);
            // 
            // pREGUNTA3ToolStripMenuItem
            // 
            this.pREGUNTA3ToolStripMenuItem.Name = "pREGUNTA3ToolStripMenuItem";
            this.pREGUNTA3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pREGUNTA3ToolStripMenuItem.Text = "PREGUNTA3";
            this.pREGUNTA3ToolStripMenuItem.Click += new System.EventHandler(this.pREGUNTA3ToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 344);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pREGUNTA1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pREGUNTA1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pREGUNTA2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pREGUNTA3ToolStripMenuItem;
    }
}