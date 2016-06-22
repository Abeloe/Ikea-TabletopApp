using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IkeaTabletopApp.Model;

namespace IkeaTabletopApp.Persistency
{
    public class ListWidthLengthSingleton
    {
        private static ListWidthLengthSingleton intance= new ListWidthLengthSingleton();

        public static ListWidthLengthSingleton Intance
        {
            get { return intance; }
        }

        public List<WidthLength> ListObjSingletonList { get; set; }

        private ListWidthLengthSingleton()
        {
            ListObjSingletonList= new List<WidthLength>();
        }
    }
}
