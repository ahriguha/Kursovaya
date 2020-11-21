namespace TemperTestingBayes
{
    partial class MainForm
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
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(584, 25);
            this.titleBarPanel.TabIndex = 0;
            this.titleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBarPanel_MouseDown);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(584, 275);
            this.panelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 300);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.titleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBarPanel;
        private System.Windows.Forms.Panel panelMain;
    }
}