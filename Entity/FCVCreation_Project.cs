using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.OOPCODE;

namespace Entity
{
    public partial class FCVCreation_Project : Form
    {
        private Project pro;
        private List<string> skills = new List<string>();
        FJobSKills fSkills;
        public FCVCreation_Project()
        {
            InitializeComponent();
            pro = new Project();
            fSkills = new FJobSKills();
            fSkills.btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            flpSkills.Controls.Clear();
            skills = fSkills.Skills;
            foreach (string item in fSkills.Skills)
            {
                if (item != "NULL")
                {
                    BtnSkill btnSkill = new BtnSkill();
                    btnSkill.Text = item;
                    btnSkill.Show();
                    flpSkills.Controls.Add(btnSkill);
                    flpSkills.Width += btnSkill.Width + 20;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pro = new Project(txtProjectName.Text, skills, dtpStartDate.Value, dtpEndDate.Value);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSkills_Click(object sender, EventArgs e)
        {
            fSkills.Show();
        }
        public Project PRO
        { get { return pro; } }
    }
}
