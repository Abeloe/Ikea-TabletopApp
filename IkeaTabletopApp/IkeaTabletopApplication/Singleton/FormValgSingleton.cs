using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkeaTabletopApplication.Singleton
{
    public class FormValgSingleton
    {
        private static FormValgSingleton intance = new FormValgSingleton();

        public static FormValgSingleton Instance
        {
            get { return intance; }
        }

        public List<int> ListFormValg { get; set; }

        private FormValgSingleton()
        {
            ListFormValg = new List<int>();
        }
    }
}
