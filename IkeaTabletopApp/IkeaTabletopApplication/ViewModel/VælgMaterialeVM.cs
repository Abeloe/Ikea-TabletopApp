using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Eventmaker.Common;
using IkeaTabletopApplication.Annotations;
using IkeaTabletopApplication.Singleton;
using IkeaTabletopApplication.VIew;

namespace IkeaTabletopApplication.ViewModel
{
    public class VælgMaterialeVM:INotifyPropertyChanged
    {

        public MaterialeValgSingleton MaterialeValgSingleton { get; set; }
        public FormValgSingleton FormValgSingleton { get; set; }
        public string SelectedItem { get; set; }
        public RelayCommand NavigateToDlCommand { get; set; }
        public RelayCommand AkrylToTykkelseNavigateCommand { get; set; }
        public RelayCommand MassivTræToTykkelseNavigateCommand { get; set; }
        public RelayCommand LaminatToTykkelseNavigateCommand { get; set; }
        public RelayCommand KvartsToTykkelseNavigateCommand { get; set; }

        public VælgMaterialeVM()
        {
            MaterialeValgSingleton= MaterialeValgSingleton.Instance;
            FormValgSingleton= FormValgSingleton.Instance;
           //NavigateToDlCommand=new RelayCommand(NavigateToDL);
           AkrylToTykkelseNavigateCommand = new RelayCommand(NavigateToAkrylTykkelse);
            LaminatToTykkelseNavigateCommand = new RelayCommand(NavigateToLaminatTykkelse);
            MassivTræToTykkelseNavigateCommand = new RelayCommand(NavigateToMassivTræTykkelse);
            KvartsToTykkelseNavigateCommand = new RelayCommand(NavigateToKvartsTykkelse);

        }

        //public void MaterialeCheckOgAdd()
        //{
        //    string check = SelectedItem;
                
               
        //    switch (check)
        //    {
        //        case "Akryl":
        //            MaterialeValgSingleton.ListMaterialeValg.Add(1);
        //            break;
        //        case "Kvarts":
        //            MaterialeValgSingleton.ListMaterialeValg.Add(2);
        //            break;
        //        case "Laminat":
        //            MaterialeValgSingleton.ListMaterialeValg.Add(3);           
        //            break;
        //        case "Massiv træ":
        //            MaterialeValgSingleton.ListMaterialeValg.Add(4);
        //            break;
        //    }
        //}

       //public void NavigateToDL()
       // {
       //     Frame rootFrame = Window.Current.Content as Frame;
       //     int check = FormValgSingleton.ListFormValg[0];

       //     switch (check)
       //     {
       //         case 1:
       //             rootFrame.Navigate(typeof(VælgDLpåL_form));
       //             break;
       //         case 2:
       //            rootFrame.Navigate(typeof (VælgDLpåU_Form));
       //             break;
       //         case 3:
       //            rootFrame.Navigate(typeof (VælgDLRektangulær));
       //             break;

       //     }
               
        //}

        public void NavigateToAkrylTykkelse()
        {
            MaterialeValgSingleton.ListMaterialeValg.Add(1);
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(MaterialeTykkelse));
           
        }

        public void NavigateToKvartsTykkelse()
        {
            MaterialeValgSingleton.ListMaterialeValg.Add(2);
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(MaterialeTykkelse));

        }
        public void NavigateToLaminatTykkelse()
        {
            MaterialeValgSingleton.ListMaterialeValg.Add(3);
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(MaterialeTykkelse));

        }

        public void NavigateToMassivTræTykkelse()
        {
            MaterialeValgSingleton.ListMaterialeValg.Add(4);
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(MaterialeTykkelse));

        }

        #region propertychanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}
