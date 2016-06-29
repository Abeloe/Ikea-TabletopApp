using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Eventmaker.Common;
using IkeaTabletopApplication.Annotations;
using IkeaTabletopApplication.Model;
using IkeaTabletopApplication.Singleton;
using IkeaTabletopApplication.VIew;

namespace IkeaTabletopApplication.ViewModel
{
    public class VælgDLRektangulærVM:INotifyPropertyChanged
    {
        public DLClass DL { get; set; }
        public DLSingleton DlSingleton { get; set; }
        public RelayCommand NavigateToMaterialeCommand { get; set; }

        public VælgDLRektangulærVM()
        {
            DL= new DLClass();
            DlSingleton= DLSingleton.Instance;
            NavigateToMaterialeCommand= new RelayCommand(NavigateToMateriale);

        }

        public void NavigateToMateriale()
        {
            DL.C = DL.A;
            DL.D = DL.B;
            DlSingleton.ListDLSingleton.Add(DL);
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(VælgMateriale));
        }

        #region propertycahnged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}
