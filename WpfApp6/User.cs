using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class User : INotifyPropertyChanged
    {
        private string name;
        public string email { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; if (null != PropertyChanged) PropertyChanged(this, new PropertyChangedEventArgs("Name")); }
        }

        public User(string name1, string email1)
        {
            Name = name1;
            email = email1;
        }

        public override string ToString()
        {
            return Name;
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
