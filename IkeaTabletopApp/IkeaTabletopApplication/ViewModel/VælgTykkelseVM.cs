using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
   public class VælgTykkelseVM : INotifyPropertyChanged
    {
       public TykkelseSingelton TykkelseSingelton { get; set; }
       public List<string> AkrylTykkelseList { get; set; }
       public List<string> KvartsTykkelseList { get; set; }
       public List<string> LaminatTykkelseList { get; set; }
       public List<string> MassivtræTykkelseList { get; set; }
       public ObservableCollection<string> TykkelseOC { get; set; }
       public MaterialeValgSingleton MaterialeValgSingleton { get; set; }
       public RelayCommand NavigateToFarveCommad { get; set; }
      

       public VælgTykkelseVM()
       {
            NavigateToFarveCommad = new RelayCommand(FarveValgNavigate);
            TykkelseOC = new ObservableCollection<string>();
            MaterialeValgSingleton = MaterialeValgSingleton.Instance;
            TykkelseSingelton  = TykkelseSingelton.Instance;
            AkrylTykkelseList = new List<string>();
            KvartsTykkelseList = new List<string>();
            LaminatTykkelseList = new List<string>();
            MassivtræTykkelseList = new List<string>();

            MassivtræTykkelseList.Add("38mm");
            AkrylTykkelseList.Add("38mm");

            LaminatTykkelseList.Add("28mm");
            LaminatTykkelseList.Add("38mm");
            LaminatTykkelseList.Add("77mm");
            CheckTykkelse();
       }

       public void CheckTykkelse()
       {
           int check = MaterialeValgSingleton.ListMaterialeValg.FirstOrDefault();

           switch (check)
           {
                case 1:
                   foreach (var Tykkelse in AkrylTykkelseList)
                   {
                       TykkelseOC.Add(Tykkelse);
                   }
                    break;
                case 2:
                   foreach (var Tykkelse in KvartsTykkelseList)
                   {
                       TykkelseOC.Add(Tykkelse);
                   }
                    break;
                case 3:
                   foreach (var Tykkelse in LaminatTykkelseList)
                   {
                       TykkelseOC.Add(Tykkelse);
                   }
                    break;
                case 4:
                   foreach (var Tykkelse in MassivtræTykkelseList)
                   {
                       TykkelseOC.Add(Tykkelse);
                   }
                    break;

                    
           }

          
       }

       public void FarveValgNavigate()
       {
            CheckTykkelse();
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(VælgFarve));

        }
       #region 

       public event PropertyChangedEventHandler PropertyChanged;

       [NotifyPropertyChangedInvocator]
       protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
       {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
       }
    }

    #endregion


    
}
