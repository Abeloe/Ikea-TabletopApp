using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkeaTabletopApplication.Singleton
{
   public class TykkelseSingelton
    {
        private static TykkelseSingelton intance = new TykkelseSingelton();

        public static TykkelseSingelton Instance
        {
            get { return intance; }
        }

        public List<string> ListTykkelseValg { get; set; }

        private TykkelseSingelton()
        {
            ListTykkelseValg = new List<string>();
        }
    }
}
