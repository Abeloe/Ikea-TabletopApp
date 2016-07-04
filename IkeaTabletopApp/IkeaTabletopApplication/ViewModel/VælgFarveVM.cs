using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using IkeaTabletopApplication.Annotations;
using IkeaTabletopApplication.Singleton;

namespace IkeaTabletopApplication.ViewModel
{
    public class VælgFarveVM : INotifyPropertyChanged
    {
        public FarveValgSingleton FarveValgSingleton { get; set; }
        public List<string> LaminatFarveList { get; set; }
        public List<string> AkrylFarveList { get; set; }
        public List<string> MassivræFarveList { get; set; }
        public List<string> KvartsFarveList { get; set; }
        public ObservableCollection<string> FarveOC { get; set; }
        public MaterialeValgSingleton MaterialeValgSingleton { get; set; }
        

        
        public VælgFarveVM()
        {
            MaterialeValgSingleton = MaterialeValgSingleton.Instance;
            FarveValgSingleton = FarveValgSingleton.Instance;
            LaminatFarveList = new List<string>();
            AkrylFarveList = new List<string>();
            MassivræFarveList = new List<string>();
            KvartsFarveList = new List<string>();

            KvartsFarveList.Add("KvartsFarve1");
            KvartsFarveList.Add("KvartsFarve2");

            LaminatFarveList.Add("LaminatFarve1");
            LaminatFarveList.Add("LaminatFarve2");

            AkrylFarveList.Add("AkrylFarve1");
            AkrylFarveList.Add("AkrylFarve2");

            MassivræFarveList.Add("MassivtræFarve1");
            MassivræFarveList.Add("MassivtræFarve2");

            FarveOC = new ObservableCollection<string>();
            CheckMaterialeAddFarve();

        }





        public void CheckMaterialeAddFarve()
        {

            int check = MaterialeValgSingleton.ListMaterialeValg.FirstOrDefault();

            switch (check)
            {
               
                case 1:
                    foreach (var farve in AkrylFarveList)
                    {
                        FarveOC.Add(farve);
                    }

                    break;
                case 2:
                    foreach (var farve in KvartsFarveList)
                    {
                        FarveOC.Add(farve);
                    }
                    break;
                case 3:
                    foreach (var farve in LaminatFarveList)
                    {
                        FarveOC.Add(farve);
                    }
                    break;
                case 4:
                    foreach (var farve in MassivræFarveList)
                    {
                        FarveOC.Add(farve);
                    }
                    break;
                    

            }

        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


