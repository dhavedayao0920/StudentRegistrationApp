using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApp.Entities
{
  public class BusinessBase : INotifyPropertyChanged
  {
    public bool IsDirty { get; set; }

    /// <summary>
    ///     PropertyChanged
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    ///     OnPropertyChanged
    /// </summary>
    /// <param name="propertyName">Property Name</param>
    protected virtual void OnPropertyChanged(string propertyName)
    {
      OnPropertyChanged(propertyName, true);
    }

    /// <summary>
    ///     OnPropertyChanged
    /// </summary>
    /// <param name="propertyName">Property Name</param>
    /// <param name="makeDirty">Make Dirty</param>
    protected virtual void OnPropertyChanged(string propertyName, bool makeDirty)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

      if (makeDirty)
        IsDirty = true;
    }

    /// <summary>
    ///     Mark Clean
    /// </summary>
    public void MarkClean()
    {
      IsDirty = false;
    }

    public void MarkDirty()
    {
      IsDirty = true;
    }

    public object Clone()
    {
      return this.MemberwiseClone();
    }
  }
}