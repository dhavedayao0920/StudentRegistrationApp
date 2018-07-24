using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApp.Entities
{
  public class Student : BusinessBase
  {
    private int _Id;
    public int Id
    {
      get { return _Id; }
      set
      {
        _Id = value;
        OnPropertyChanged(nameof(Id));
      }
    }

    private string _FirstName;

    public string FirstName
    {
      get
      {
        return _FirstName;
      }
      set
      {
        _FirstName = value;
        OnPropertyChanged(nameof(FirstName));
      }
    }

    private string _LastName;

    public string LastName
    {
      get
      {
        return _LastName;
      }
      set
      {
        _LastName = value;
        OnPropertyChanged(nameof(LastName));
      }
    }
  }
}
