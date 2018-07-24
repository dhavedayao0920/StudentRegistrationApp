using StudentRegistrationApp.Data;
using StudentRegistrationApp.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApp.Models
{
  public class StudentModel
  {
    private IStudentRepository _Repository;
    public StudentModel(IStudentRepository repository)
    {
      _Repository = repository;
    }

    public List<Student> GetStudents()
    {
      return _Repository.GetStudents();
    }
  }
}
