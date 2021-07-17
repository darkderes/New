using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace New.ViewModels
{
    public abstract class ViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
