using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRegistrationApp.Entities;

namespace StudentRegistrationApp.Data
{
  public class DummyStudentRepository : IStudentRepository
  {
    public List<Student> _StudentList = new List<Student>();
    public DummyStudentRepository()
    {
      _StudentList.Add(new Student() { FirstName = "Dhave", MiddleName = "Pangyarihan", LastName = "Dayao", Birthday = new DateTime(1989, 9, 20), TelNum = "0999999999", PropAddress = "B. Cruz St. Tangos, Navotas City" });
      _StudentList.Add(new Student() { FirstName = "Jan Michael", MiddleName = "Liwanag", LastName = "Matias", Birthday = new DateTime(1989, 2, 22), TelNum = "0998888888", PropAddress = "A. Cruz St. Tangos, Navotas City" });
    }

    public void AddStudent(Student student)
    {
      _StudentList.Add(student);
    }

    public List<Student> GetStudents()
    {
      return _StudentList;
    }
  }
}
