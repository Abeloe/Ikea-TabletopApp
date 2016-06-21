using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IkeaTabletopApp.Model;

namespace IkeaTabletopApp.Persistency
{
    public class ListObjSingleton
    {
        private static ListObjSingleton intance= new ListObjSingleton();

        public static ListObjSingleton Intance
        {
            get { return intance; }
        }

        public List<WidthLength> ListObjSingletonList { get; set; }

        private ListObjSingleton()
        {
            ListObjSingletonList= new List<WidthLength>();
        }
    }
}
