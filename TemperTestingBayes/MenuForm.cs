using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TemperTestingBayes
{
    public partial class MenuForm : Form
    {
        MainForm mainForm;
        public MenuForm()
        {
            InitializeComponent();
            mainForm = new MainForm();
            mainForm.SetParentForm(this);
        }

       
        private void buttonTest_Click(object sender, EventArgs e)
        {
            if (!mainForm.Visible)
            {
                mainForm.Show();
                mainForm.Location = new Point(Location.X + 200, Location.Y);
            }
            mainForm.setTestPanel();
        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (!mainForm.Visible)
            {
                mainForm.Show();
                mainForm.Location = new Point(Location.X + 200, Location.Y);
            }
            mainForm.setInfoPanel();
        }

        private void buttonAiTest_Click(object sender, EventArgs e)
        {
            if (!mainForm.Visible)
            {
                mainForm.Show();
                mainForm.Location = new Point(Location.X + 200, Location.Y);
            }
            mainForm.setAiTestPanel();
        }

        private void MenuForm_Move(object sender, EventArgs e)
        {
            if (mainForm.Visible)
            {               
                mainForm.Location = new Point(Location.X + 200, Location.Y);
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void titleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

   
        public void lockButtons(bool parameter)
        {
            buttonTest.Enabled = parameter;
            buttonInfo.Enabled = parameter;
            buttonAiTest.Enabled = parameter;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Brown;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.DarkRed;
        }

       
    }
}
