
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class Experience
    {
        private string jobtitle;
        private string company;
        private string location;
        private string achieve;
        private DateTime datestart;
        private DateTime dateend;

        public Experience()
        {
            jobtitle = string.Empty;
            company = string.Empty;
            location = string.Empty;
            achieve = string.Empty;
            datestart = DateTime.MinValue;
            dateend = DateTime.MinValue;
        }

        public Experience(string jobtitle, string company, string location, string achieve, DateTime datestart, DateTime dateend)
        {
            this.jobtitle = jobtitle;
            this.company = company;
            this.location = location;
            this.achieve = achieve;
            this.datestart = datestart;
            this.dateend = dateend;
        }

        public string Title
        { get { return jobtitle; } }
        public string Company { get { return company; } }
        public string Location { get { return location; } }
        public string Achieve { get {  return achieve; } }
        public DateTime Datestart { get {  return datestart; } }
        public DateTime Dateend { get {  return dateend; } }


    }
}
