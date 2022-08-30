namespace NoSleepNo
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.haloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Check = new System.Windows.Forms.ToolStripComboBox();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.haloToolStripMenuItem,
            this.Check});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.ShowCheckMargin = true;
            this.contextMenuStrip3.Size = new System.Drawing.Size(204, 53);
            // 
            // haloToolStripMenuItem
            // 
            this.haloToolStripMenuItem.Name = "haloToolStripMenuItem";
            this.haloToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.haloToolStripMenuItem.Text = "Halo";
            // 
            // Check
            // 
            this.Check.AccessibleDescription = "Check";
            this.Check.AccessibleName = "Check";
            this.Check.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(121, 23);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem haloToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox Check;
    }
}

