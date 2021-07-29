using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Input;
using New.Models;
using New.Services;
using Xamarin.Forms;

namespace New.ViewModels
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigate Navigation { get; set; } = new Navigator();
    }
}
