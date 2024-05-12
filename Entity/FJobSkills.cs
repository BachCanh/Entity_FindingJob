using Guna.UI2.WinForms;
using ReaLTaiizor.Controls;
using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public partial class FJobSKills : Form
    {
        const int maxSkills = 3;
        public event EventHandler<List<string>> ListReady;
        List<string> skills = new List<string>();
        public FJobSKills(List<string> skills)
        {
            InitializeComponent();
            this.skills = skills;
        }

        public FJobSKills()
        {
            InitializeComponent();
        }
        
        private void FJobSKills_Load(object sender, EventArgs e)
        {
            SetAllButtonClick(pnBody);
            CheckList(pnBody);
        }


        public void SetAllButtonClick(Guna2Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Guna2Button)
                {
                    Guna2Button button = (Guna2Button)control;
                    button.Click += button_Click;
                }
                else if (control is Guna2Panel)
                    SetAllButtonClick((Guna2Panel)control);
            }
        }

        public void FirstClicked(Guna2Button button)
        {
            button.Image = Properties.Resources.approve;
            button.FillColor = Color.FromArgb(248, 212, 187);
            button.Tag = 1;
            lblCountSkills.Text = (maxSkills - skills.Count).ToString() + " Skill(s) remaining";
        }

        public void SecondClicked(Guna2Button button)
        {
            button.Image = Properties.Resources.plus;
            button.FillColor = Color.Silver;
            lblCountSkills.Text = (maxSkills - skills.Count).ToString() + " Skill(s) remaining";
        }

        public void CheckList(Guna2Panel panel)
        {
            List<string> skillsCopy = new List<string>(skills);
            foreach (Control control in panel.Controls)
            {
                if (control is Guna2Button button)
                {
                    foreach(string s in skillsCopy)
                    {
                        if (button.Text == s)
                        {
                            FirstClicked(button);
                        }
                    }
                }
                else if (control is Guna2Panel)
                    CheckList((Guna2Panel)control);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = (Guna2Button)sender;

            if (clickedButton.Tag == null)
            {
                clickedButton.Tag = 0;
            }

            int buttonClickCount = (int)clickedButton.Tag;

            buttonClickCount++;

            if (buttonClickCount == 2)
            {
                skills.Remove(clickedButton.Text);
                SecondClicked(clickedButton);
                buttonClickCount = 0;
            }
            else if (buttonClickCount == 1)
            {
                if (skills.Count >= 3)
                {
                    MessageBox.Show("You can only choose 3 skills for each job!");
                    return;
                }
                skills.Add(clickedButton.Text);
                FirstClicked(clickedButton);
            }
            clickedButton.Tag = buttonClickCount;
        }

        private void PassListBackToListener()
        {
            ListReady?.Invoke(this, skills);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PassListBackToListener();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PassListBackToListener();
            this.Hide();
        }

        public List<string> Skills
        { get { return skills; } }
    }
}
