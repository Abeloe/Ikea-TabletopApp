using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkeaTabletopApplication.Singleton
{
   public class FarveValgSingleton
    {
        private static FarveValgSingleton intance = new FarveValgSingleton();

        public static FarveValgSingleton Instance
        {
            get { return intance; }
        }

        public List<string> ListFarveValg { get; set; }

        private FarveValgSingleton()
        {
            ListFarveValg = new List<string>();
        }
    }

}
