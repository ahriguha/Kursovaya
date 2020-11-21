namespace TemperTestingBayes
{
    partial class MenuForm
    {

        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.buttonTest = new System.Windows.Forms.Button();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.buttonAiTest = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleBarPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTest
            // 
            this.buttonTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTest.FlatAppearance.BorderSize = 0;
            this.buttonTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTest.Location = new System.Drawing.Point(0, 0);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(253, 65);
            this.buttonTest.TabIndex = 0;
            this.buttonTest.Text = "ПРОЙТИ ТЕСТ";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.titleBarPanel.Controls.Add(this.buttonExit);
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.titleBarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(253, 31);
            this.titleBarPanel.TabIndex = 1;
            this.titleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBarPanel_MouseDown);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Brown;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(220, 0);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(33, 31);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.buttonAiTest);
            this.menuPanel.Controls.Add(this.buttonInfo);
            this.menuPanel.Controls.Add(this.buttonTest);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuPanel.Location = new System.Drawing.Point(0, 174);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(253, 195);
            this.menuPanel.TabIndex = 2;
            // 
            // buttonAiTest
            // 
            this.buttonAiTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAiTest.FlatAppearance.BorderSize = 0;
            this.buttonAiTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAiTest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAiTest.Location = new System.Drawing.Point(0, 130);
            this.buttonAiTest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAiTest.Name = "buttonAiTest";
            this.buttonAiTest.Size = new System.Drawing.Size(253, 65);
            this.buttonAiTest.TabIndex = 2;
            this.buttonAiTest.Text = "ТЕСТ АЙЗЕНКА";
            this.buttonAiTest.UseVisualStyleBackColor = true;
            this.buttonAiTest.Click += new System.EventHandler(this.buttonAiTest_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo.Location = new System.Drawing.Point(0, 65);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(253, 65);
            this.buttonInfo.TabIndex = 1;
            this.buttonInfo.Text = "ИНСТРУКЦИЯ";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titleBarPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.Text = "`  ";
            this.Move += new System.EventHandler(this.MenuForm_Move);
            this.titleBarPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Panel titleBarPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonAiTest;
    }
}

