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
        public RelayCommand LFormNavigateToDLCommand { get; set; }
        public RelayCommand UFormNavigateToDLCommand { get; set; }
        public RelayCommand RectangularNavigateToDLCommand { get; set; }

      

        public BordpladeFormVM()
        {
            LFormNavigateToDLCommand = new RelayCommand(LFormNavigateToDL);
            UFormNavigateToDLCommand = new RelayCommand(UFormNavigateToDL);
            RectangularNavigateToDLCommand = new RelayCommand(RectangularFormNavigateToDL);
           
        }

        public void LFormNavigateToDL()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(VælgDLpåL_form));
        }

       public void UFormNavigateToDL()
       {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(VælgDLpåU_Form));
        }

       public void RectangularFormNavigateToDL()
       {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(VælgDLRektangulær));
        }
    }
}
