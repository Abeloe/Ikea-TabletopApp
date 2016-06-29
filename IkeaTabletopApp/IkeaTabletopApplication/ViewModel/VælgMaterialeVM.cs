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
using IkeaTabletopApplication.Singleton;
using IkeaTabletopApplication.VIew;

namespace IkeaTabletopApplication.ViewModel
{
    public class VælgMaterialeVM:INotifyPropertyChanged
    {

        public List<string> MaterialeListe { get; set; }
        public MaterialeValgSingleton MaterialeValgSingleton { get; set; }
        public FormValgSingleton FormValgSingleton { get; set; }
        public string SelectedItem { get; set; }
        public RelayCommand NavigateToDlCommand { get; set; }


        public VælgMaterialeVM()
        {
            MaterialeValgSingleton= MaterialeValgSingleton.Instance;
            FormValgSingleton= FormValgSingleton.Instance;

            MaterialeListe= new List<string>();

            MaterialeListe.Add("Akryl");
            MaterialeListe.Add("Kvarts");
            MaterialeListe.Add("Laminat");
            MaterialeListe.Add("Massiv træ");
            NavigateToDlCommand=new RelayCommand(NavigateToDL);

        }

        public void MaterialeCheckOgAdd()
        {
            string check = SelectedItem;
            switch (check)
            {
                case "Akryl":
                    MaterialeValgSingleton.ListMaterialeValg.Add(1);
                    break;
                case "Kvarts":
                    MaterialeValgSingleton.ListMaterialeValg.Add(2);
                    break;
                case "Laminat":
                    MaterialeValgSingleton.ListMaterialeValg.Add(3);
                    break;
                case "Massiv træ":
                    MaterialeValgSingleton.ListMaterialeValg.Add(4);
                    break;
            }
        }

        public void NavigateToDL()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            int check = FormValgSingleton.ListFormValg[0];

            switch (check)
            {
                case 1:
                    rootFrame.Navigate(typeof(VælgDLpåL_form));
                    MaterialeCheckOgAdd();
                    break;
                case 2:
                    rootFrame.Navigate(typeof (VælgDLpåU_Form));
                    MaterialeCheckOgAdd();
                    break;
                case 3:
                    rootFrame.Navigate(typeof (VælgDLRektangulær));
                    MaterialeCheckOgAdd();
                    break;

            }
               
            

            
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
