// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DZ_Resume_Pattern_Builder_2;

Employee jelena = new EmployeeBuilder().SetName("Jelena").SetSurname("Krock")
    .SetYearOfBirth(2002)
    .SetE_Mail("jelena.krock@gmail.com")
    .SetEducation("IT STEP ACADEMY")
    .SetCompetences(new List<string>() { "C#", "ADO.NET", "System Programming", "Network Programming" });

Employee dim = Employee.CreateBuilder().SetName("Dmytro").SetSurname("Fomin")
    .SetYearOfBirth(2005);

Employee deniss = Employee.CreateBuilder().SetName("Deniss").SetSurname("Bojko")
    .SetYearOfBirth(1992).SetTelephone("+380671112233").SetE_Mail("deniss.bojko@gmail.com")
    .SetEducation("IT STEP ACADEMY")
    .SetCompetences(new List<string> { "C++", "C#", "Java", "PHP", "JS" })
    .SetWorkExperiences(new List<int> { 2, 1, 3, 1, 1});


//Console.WriteLine(dim.ToString());
//Console.WriteLine("------------------------------");
//Console.WriteLine(jelena.ToString());

List<Employee> employees = new List<Employee>();
employees.Add(dim);
employees.Add(deniss);
employees.Add(jelena);

foreach (var item in employees)
{
    Console.WriteLine(item.ToString());
}