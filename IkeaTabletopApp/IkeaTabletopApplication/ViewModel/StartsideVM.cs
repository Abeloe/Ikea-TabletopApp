using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Eventmaker.Common;
using IkeaTabletopApplication.Annotations;
using IkeaTabletopApplication.VIew;

namespace IkeaTabletopApplication.ViewModel
{
   public class StartsideVM:INotifyPropertyChanged
    {
       public RelayCommand NavigateToBordpladeFormCommand { get; set; }

       public StartsideVM()
       {
          NavigateToBordpladeFormCommand= new RelayCommand(NavigateToBordpladeForm);
       }

       public void NavigateToBordpladeForm()
       {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(BordpladeType));
        }

        #region propertychanged helper
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}
