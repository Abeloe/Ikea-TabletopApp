using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IkeaTabletopApplication.Model;

namespace IkeaTabletopApplication.Singleton
{
    public class DLSingleton
    {
        private static DLSingleton intance = new DLSingleton();

        public static DLSingleton Instance
        {
            get { return intance; }
        }

        public List<DLClass> ListDLSingleton { get; set; }

        private DLSingleton()
        {

            ListDLSingleton = new List<DLClass>();
        }
    }
}
