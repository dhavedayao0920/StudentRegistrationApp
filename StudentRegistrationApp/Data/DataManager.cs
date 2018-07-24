using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApp.Data
{
  public class DataManager
  {
    static readonly DataManager _instance = new DataManager();
    public static DataManager Instance
    {
      get
      {
        return _instance;
      }
    }

    public DataManager()
    {
      Students = new DummyStudentRepository();
    }

    public IStudentRepository Students { get; set; }
  }
}
