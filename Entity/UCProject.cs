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
    public partial class UCProject : UserControl
    {
        private Project pro;
        public UCProject(Project pro)
        {
            InitializeComponent();
            this.pro = pro;
            FillInfor();
        }

        private void FillInfor()
        {
            lblPeriod.Text = "(" + pro.Datestart.ToString("yyyy") + " - " + pro.Dateend.ToString("yyyy") + ")";
            lblProjects.Text = pro.Title;
            flpSkills.Controls.Clear();
            foreach (string item in pro.Skills)
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
    }
}
