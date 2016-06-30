using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkeaTabletopApplication.Singleton
{
    public class MaterialeValgSingleton
    {
        private static MaterialeValgSingleton intance = new MaterialeValgSingleton();

        public static MaterialeValgSingleton Instance
        {
            get { return intance; }
        }

        public List<int> ListMaterialeValg { get; set; }

        private MaterialeValgSingleton()
        {
          ListMaterialeValg= new List<int>();
        }
    }
}
