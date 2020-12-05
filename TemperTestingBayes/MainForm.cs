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
using System.Threading;
using System.IO;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;

namespace TemperTestingBayes
{
    public partial class MainForm : Form
    {
        Form menuForm;
        Classifier classifier;
        bool testIsRunning = false;
        int[,] trainTable;

        public MainForm()
        {
            InitializeComponent();
            trainTable = File_Reader.GetTrainTable(Directory.GetCurrentDirectory() + @"\trainTable.txt");
            classifier = new Classifier();
            classifier.Fit(trainTable);
        }

        public void SetParentForm(Form parentForm)
        {
            menuForm = parentForm;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void MainForm_Move(object sender, EventArgs e)
        {
            menuForm.Location = new Point(Location.X - 200, Location.Y);
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

        public void setTestPanel()
        {
            if (!testIsRunning)
            {
                panelMain.Controls.Clear();
                this.Height = 300;
                this.Width = 584;
                Button buttonStart = new Button();
                buttonStart.Dock = DockStyle.Fill;
                buttonStart.Height = 50;
                buttonStart.Text = "START TEST";
                buttonStart.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                buttonStart.Click += new EventHandler(this.testStart);
                panelMain.Controls.Add(buttonStart);
            }
        }

        public void setInfoPanel()
        {
            if (!testIsRunning)
            {
                panelMain.Controls.Clear();
                List<Button> infoButtons = GetInfoButtons();
                this.Height = 300;
                this.Width = 584;
                //buttonInf.Click += new EventHandler(this.setInfoButtons);                
                for (int i = 0; i < 4; i++)
                {
                    infoButtons[i].Click += (object sender, EventArgs e) => 
                    showInfo(int.Parse((sender as Button).Name));
                }
                foreach (Button bt in infoButtons)
                {
                    panelMain.Controls.Add(bt);
                }
            }
        }

        public void setAiTestPanel()
        {
            if (!testIsRunning)
            {
                panelMain.Controls.Clear();
                WebView2 testPage = new WebView2();
                testPage.Dock = DockStyle.Fill;
                this.Height = 450;
                this.Width = 584;
                //https://www.idrlabs.com/pen-personality/test.php
                //https://testometrika.com/personality-and-temper/questionnaire-eysenck-pen/
                //https://psytests.org/eysenck/epiA-run.html
                testPage.Source = new System.Uri("https://www.idrlabs.com/pen-personality/test.php");
                panelMain.Controls.Add(testPage);
            }
        }


        private List<Button> GetInfoButtons()
        {
            List<Button> infoButtons = new List<Button>()
            {
                new Button(),
                new Button(),
                new Button(),
                new Button()
            };
            foreach(Button b in infoButtons)
            {
                b.Dock = DockStyle.Right;
                b.Width = panelMain.Width/4;                
                b.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
            infoButtons[0].Text = "Melancholic";
            infoButtons[0].Name = "1";
            infoButtons[1].Text = "Choleric";
            infoButtons[1].Name = "2";
            infoButtons[2].Text = "Sanguine";
            infoButtons[2].Name = "3";
            infoButtons[3].Text = "Phlegmatic";
            infoButtons[3].Name = "4";
            return infoButtons;
        }

        private void showInfo(int arg)
        {
            panelMain.Controls.Clear();
            Label labelTitle = new Label();
            labelTitle.Location = new Point(60, 60);
            labelTitle.Size = new Size(220, 25);           
            labelTitle.Font = new Font("Century Gothic", 15F, FontStyle.Bold);           

            Label labelResult = new Label();
            labelResult.Location = new Point(280, 60);
            labelResult.Size = new Size(250, 180);
            labelResult.Font = new Font("Century Gothic", 11F, FontStyle.Bold);

            Button backButton = new Button();
            backButton.Dock = DockStyle.Bottom;
            backButton.Text = "Back";
            backButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            backButton.Height = 30;
            backButton.Click += (object sender, EventArgs e) => setInfoPanel();
            switch (arg)
            {
                case 1:
                    {
                        labelTitle.Text = "Melancholic";
                        labelResult.Text = "The Perfectionist."+
                            "Sensitive, thoughtful, quiet.";
                        break;
                    }
                case 2:
                    {
                        labelTitle.Text = "Choleric";
                        labelResult.Text = "The Natural Leader."+
                            "Determined, energetic, goal - oriented.";
                        break;
                    }
                case 3:
                    {
                        labelTitle.Text = "Sanguine";
                        labelResult.Text = "The Life of the Party." +
                            "Enthusiastic, fun - loving, outgoing.";
                        break;
                    }
                case 4:
                    {
                        labelTitle.Text = "Phlegmatic";
                        labelResult.Text = "The Peacemaker." +
                            "Easy - going, calm, chill.";
                        break;
                    }
            }
            
            panelMain.Controls.Add(labelResult);
            panelMain.Controls.Add(labelTitle);
            panelMain.Controls.Add(backButton);
        }

        private void testStart(object sender, EventArgs e)
        {
            testIsRunning = true;
            MessageBox.Show("Choose the quality, that suits you best");       
            testProcess();
        }

        private void testProcess()
        {
            List<string[]> quests = File_Reader.GetQuestions(Directory.GetCurrentDirectory() + @"\testQuestions.txt");
            panelMain.Controls.Clear();
            List<Label> labels = GetTestLabels();
            int[] testResult = new int[5];
            int i = 0;
            for (int j = 0; j < 4; j++)
            {
                labels[j].Text = quests[i][j];
            }
            for (int j = 0; j < 4; j++)
            {
                labels[j].Click += delegate (object sender, EventArgs e)
                {
                    testResult[i] = int.Parse((sender as Label).Name);
                    i++;                    
                    if (i > 4)
                    {
                        testFinish(testResult);
                    }
                    else
                    {
                        labelsUpdate(ref labels, quests, i);
                    }
                };
            }
            
            foreach (Label lab in labels)
            {
                panelMain.Controls.Add(lab);
            }

        }

        private void labelsUpdate(ref List<Label> labels, List<string[]> questions, int i)
        {
            for (int j = 0; j < 4; j++)
            {
                labels[j].Text = questions[i][j];
            }               
        }
     
        private void testFinish(int[] testResult)
        {
            panelMain.Controls.Clear();
            testIsRunning = false;            
            drawResults(classifier.GetPrediction(testResult));
        }

        private void drawResults(double[] prediction)
        {
            Label labelTitle = new Label();
            labelTitle.Location = new Point(60, 60);
            labelTitle.Size = new Size(220, 25);
            labelTitle.Text = "YOUR RESULT: ";
            labelTitle.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            panelMain.Controls.Add(labelTitle);

            Label labelResult = new Label();
            labelResult.Location = new Point(280, 60);
            labelResult.Size = new Size(250, 150);
            labelResult.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            labelResult.Text += 
                "Melancholic - " + Math.Round(prediction[0]*100, 2).ToString() + "%;\n" +
                "Choleric    - " + Math.Round(prediction[1]*100, 2).ToString() + "%;\n" +
                "Sanguine  - " + Math.Round(prediction[2]*100, 2).ToString() + "%;\n" +
                "Phlegmatic - " + Math.Round(prediction[3]*100, 2).ToString() + "%;\n";
            panelMain.Controls.Add(labelResult);

            
        }

        

        private List<Label> GetTestLabels()
        {          
            List<Label> answers = new List<Label>() { new Label(), new Label(), new Label(), new Label()};            
            answers[0].Location = new Point(60, 60);
            answers[0].Size = new Size(220, 25);
            answers[0].Name = "1";
            answers[1].Location = new Point(360, 60);
            answers[1].Size = new Size(220, 25);
            answers[1].Name = "2";
            answers[2].Location = new Point(60, 150);
            answers[2].Size = new Size(220, 25);
            answers[2].Name = "3";
            answers[3].Location = new Point(360, 150);
            answers[3].Size = new Size(220, 25);
            answers[3].Name = "4";
            foreach (Label lb in answers)
            {
                lb.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }

            return answers;
        }


        

    }
}
