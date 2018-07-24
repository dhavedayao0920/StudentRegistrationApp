using StudentRegistrationApp.Data;
using StudentRegistrationApp.Entities;
using StudentRegistrationApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApp.ViewModels
{
  public class StudentListViewModel : ViewModelBase
  {
    public StudentListViewModel()
    {
      Students = new ObservableCollection<Student>(DataManager.Instance.Students.GetStudents());
    }

    private ObservableCollection<Student> _Students;

    public ObservableCollection<Student> Students
    {
      get
      {
        return _Students;
      }
      set
      {
        _Students = value;
        OnPropertyChanged(nameof(Students));
      }
    }
  }
}
