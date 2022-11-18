using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Resume_Pattern_Builder_2
{
    public class Employee
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int YearOfBirth { get; set; } 
        public string Telephone { get; set; } = null!;
        public string E_Mail { get; set; } = null!;
        public string Education { get; set; } = null!;
        public List<string> Competences { get; set; }
        public List<int> WorkExperiences { get; set; }

        public Employee()
        {
            Competences = new List<string>();
            WorkExperiences = new List<int>();
        }

        public static EmployeeBuilder CreateBuilder()
        {
            return new EmployeeBuilder();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\t\tRESUME OF EMPLOYEE\n");
            if(Name != null)
            {
                sb.AppendLine($"Name:\t\t{Name}");
            }
            if(Surname != null)
            {
                sb.AppendLine($"Surname:\t{Surname}");
            }
            if(YearOfBirth != 0)
            {
                sb.AppendLine($"Year Of Birth:\t{YearOfBirth}");
            }
            if(Telephone != null)
            {
                sb.AppendLine($"Telephone:\t{Telephone}");
            }
            if(Education != null)
            {
                sb.AppendLine($"Education:\t{Education}");
            }
            if(Competences.Count > 0)
            {
                sb.AppendLine("Competences: ");
                foreach(var item in Competences)
                {
                    sb.AppendLine($"\t\t{item}");
                }
            }
            if(WorkExperiences.Count > 0)
            {
                sb.AppendLine("WorkExperiences: ");
                foreach(var item in WorkExperiences)
                {
                    sb.AppendLine($"\t\t{item}");
                }
            }
            sb.AppendLine("------------------------------");
            return sb.ToString();
        }
    }
}