using StudentRegistrationApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApp.Data
{
  public interface IStudentRepository
  {
    List<Student> GetStudents();
    void AddStudent(Student student);
  }
}
