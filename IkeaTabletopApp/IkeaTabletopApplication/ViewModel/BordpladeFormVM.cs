using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Eventmaker.Common;
using IkeaTabletopApplication.Singleton;
using IkeaTabletopApplication.VIew;

namespace IkeaTabletopApplication.ViewModel
{
   public class BordpladeFormVM
    {
        public RelayCommand LFormNavigateToDLCommand { get; set; }
        public RelayCommand UFormNavigateToDLCommand { get; set; }
        public RelayCommand RectangularNavigateToDLCommand { get; set; }
       public FormValgSingleton FormValgSingleton { get; set; }


      

        public BordpladeFormVM()
        {
            LFormNavigateToDLCommand = new RelayCommand(LFormNavigateToMateriale);
            UFormNavigateToDLCommand = new RelayCommand(UFormNavigateToMateriale);
            RectangularNavigateToDLCommand = new RelayCommand(RectangularFormNavigateToMateriale);
            FormValgSingleton= FormValgSingleton.Instance;

           
        }

        public void LFormNavigateToMateriale()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(VælgMateriale));
            FormValgSingleton.ListFormValg.Add(1);
        }

       public void UFormNavigateToMateriale()
       {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(VælgMateriale));
            FormValgSingleton.ListFormValg.Add(2);

        }

       public void RectangularFormNavigateToMateriale()
       {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(VælgMateriale));
            FormValgSingleton.ListFormValg.Add(3);

        }

    }
}
