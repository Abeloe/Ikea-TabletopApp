using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkeaTabletopApplication.Singleton
{
   public class BordpladeformSingleton
    {
       private static BordpladeformSingleton instance = new BordpladeformSingleton();

       public static BordpladeformSingleton Instance
       {
           get { return instance;}
       }

       public List<string> BordpladeFormer { get; set; }

       private BordpladeformSingleton()
       {
          BordpladeFormer = new List<string>();
       }

    }
    
}
