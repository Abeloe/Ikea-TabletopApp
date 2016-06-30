using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkeaTabletopApplication.Singleton
{
    internal class FarveValgSingleton
    {
        private static FarveValgSingleton intance = new FarveValgSingleton();

        public static FarveValgSingleton Instance
        {
            get { return intance; }
        }

        public List<int> ListFarveValg { get; set; }

        private FarveValgSingleton()
        {
            ListFarveValg = new List<int>();
        }
    }

}
