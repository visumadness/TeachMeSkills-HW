using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class СontrolArms : Army
    {
        private string _managementDepartment;
        private string _department;
        public СontrolArms(string managementDepartment,
            string department,
            double salary,
            string position,
            double workExperience,
            string initials) : base(salary,
                                        position,
                                        workExperience,
                                        initials)
        {
            _department = department;
            _managementDepartment = managementDepartment;
        }

        public void SetManagementDepartment(string managementDepartment)
        {
            _managementDepartment=managementDepartment;
        }

        public string GetManagementDepartment()
        {
            return _managementDepartment;
        }

        public void SetDepartment(string department)
        {
            _department = department;
        }

        public string GetDepartment()
        {
            return _department;
        }

    }
}
