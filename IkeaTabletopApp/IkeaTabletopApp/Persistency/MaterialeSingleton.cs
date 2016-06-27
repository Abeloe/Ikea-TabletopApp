using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IkeaTabletopApp.Model;

namespace IkeaTabletopApp.Persistency
{
    public class MaterialeSingleton
    {
            private static MaterialeSingleton intance = new MaterialeSingleton();

            public static MaterialeSingleton Intance
            {
                get { return intance; }
            }

            public List<string> ListMaterialeSingleton { get; set; }

            private MaterialeSingleton()
            {
                
               ListMaterialeSingleton = new List<string>();
            }
        }
    
}
