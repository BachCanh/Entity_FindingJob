using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class SkillListDAO
    {
        FindingJob db = new FindingJob();


        public void AddSkillList(JobSkill jobSkill)
        {
            db.JobSkills.Add(jobSkill);
            db.SaveChanges();
        }
        public void UpdateSkillList(JobSkill skilllist)
        {
            JobSkill skill = db.JobSkills.FirstOrDefault(s => s.jobID == skilllist.jobID);
            if(skill != null)
            {
                skill.Skill1 = skilllist.Skill1;
                skill.Skill2 = skilllist.Skill2;
                skill.Skill3 = skilllist.Skill3;
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Job's Skill list not found");
            }
        }
        public List<string> GetSkills(string jobID)
        {
            List<string> lst = new List<string>();
            JobSkill skill = db.JobSkills.FirstOrDefault(s => s.jobID == jobID);
            lst.Add(skill.Skill1);
            lst.Add(skill.Skill2);
            lst.Add(skill.Skill3);
            return lst;
        }

    }
}
