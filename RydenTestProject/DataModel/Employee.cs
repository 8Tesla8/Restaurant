using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RydenTestProject.DataModel
{
    public class Employee : Client
    {
        public string Patronymic { get; set; }
        public DateTime FirstDay { get; set; }
        public DateTime Birthday { get; set; }
        public string IdentityCode { get; set; }
        public string Pasport { get; set; }
        public double Salary { get; set; }

        public EmployeeType EmployerType { get; set; }
    }
}
