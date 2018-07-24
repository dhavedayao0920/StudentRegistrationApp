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
      _StudentList.Add(new Student() { FirstName = "Dhave", LastName = "Dayao" });
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
