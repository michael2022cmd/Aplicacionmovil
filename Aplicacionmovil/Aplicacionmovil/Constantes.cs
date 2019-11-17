using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.ComponentModel;

namespace Aplicacionmovil
{
    public class maimodel : INotifyPropertyChanged
    {
        public string _user;
        public string User
        {

            get { return _user;
            }

            set { if (value != _user)
                    _user = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("User"));
                    
                        }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
    
}
