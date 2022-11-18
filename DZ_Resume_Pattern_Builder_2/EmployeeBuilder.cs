using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Resume_Pattern_Builder_2
{
    public class EmployeeBuilder
    {
        private Employee employee;

        public EmployeeBuilder()
        {
            employee = new Employee();
        }

        public EmployeeBuilder SetName(string name)
        {
            employee.Name = name;
            return this;
        }

        public EmployeeBuilder SetSurname(string surname)
        {
            employee.Surname = surname;
            return this;
        }

        public EmployeeBuilder SetYearOfBirth(int yearOfBirth)
        {
            employee.YearOfBirth = yearOfBirth;
            return this;
        }

        public EmployeeBuilder SetTelephone(string telephone)
        {
            employee.Telephone = telephone;
            return this;
        }

        public EmployeeBuilder SetE_Mail(string email)
        {
            employee.E_Mail = email;
            return this;
        }

        public EmployeeBuilder SetEducation(string education)
        {
            employee.Education = education;
            return this;
        }

        public EmployeeBuilder SetCompetences(List<string> competences)
        {
            employee.Competences = competences;
            return this;
        }

        public EmployeeBuilder SetWorkExperiences(List<int> workExperiences)
        {
            employee.WorkExperiences = workExperiences;
            return this;
        }

        public static implicit operator Employee(EmployeeBuilder builder)
        {
            return builder.employee;
        }
    }
}
