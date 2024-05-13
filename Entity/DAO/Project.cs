using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity
{
    public class Project
    {
        private string title;
        private List<string> skills;
        private DateTime datestart;
        private DateTime dateend;

        public Project() 
        {
            title = string.Empty;
            List<string> skills = new List<string>();
            dateend = DateTime.MinValue;
            datestart = DateTime.MinValue;
        }

        public Project(string title, List<string> skills, DateTime datestart, DateTime dateend)
        {
            this.title = title;
            this.skills = skills;
            this.datestart = datestart;
            this.dateend = dateend;
        }

        public string Title
        { get { return title; } }
        public List<string> Skills 
        { get {  return skills; } }
        public DateTime Datestart 
        { get { return datestart; } }
        public DateTime Dateend 
        { get {  return dateend; } }    
    }
}
