using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Eventmaker.Common;
using IkeaTabletopApplication.VIew;

namespace IkeaTabletopApplication.ViewModel
{
   public class BordpladeFormVM
    {
        public RelayCommand LFormNavigateToMaterialeCommand { get; set; }
        public RelayCommand UFormNavigateToMaterialeCommand { get; set; }
        public RelayCommand RectangularNavigateToMaterialeCommand { get; set; }

      

        public BordpladeFormVM()
        {
            LFormNavigateToMaterialeCommand = new RelayCommand(LFormNavigateToMateriale);
            UFormNavigateToMaterialeCommand = new RelayCommand(UFormNavigateToMateriale);
            RectangularNavigateToMaterialeCommand = new RelayCommand(RectangularFormNavigateToMateriale);
           
        }

        public void LFormNavigateToMateriale()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(VælgMateriale));
        }

       public void UFormNavigateToMateriale()
       {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(VælgMateriale));
        }

       public void RectangularFormNavigateToMateriale()
       {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(VælgMateriale));
        }
    }
}
