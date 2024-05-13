
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Education
    {
        private string school;
        private string degree;
        private string location;
        private string description;
        private DateTime datestart;
        private DateTime dateend;

        public Education()
        {
            school = string.Empty;
            degree = string.Empty;
            location = string.Empty;
            description = string.Empty;
            datestart = DateTime.MinValue;
            dateend = DateTime.MinValue;
        }

        public Education(string school, string degree, string location, string description, DateTime datestart, DateTime dateend)
        {
            this.school = school;
            this.degree = degree;
            this.location = location;
            this.description = description;
            this.datestart = datestart;
            this.dateend = dateend;
        }

        public string School
        { get { return school; } }
        public string Degree { get { return degree;} }
        public string Location
        { get { return location; } }
        public string Description
        { get { return description; } }
        public DateTime Datestart { get {  return datestart; } }
        public DateTime Dateend { get {  return dateend; } }

    }
}
