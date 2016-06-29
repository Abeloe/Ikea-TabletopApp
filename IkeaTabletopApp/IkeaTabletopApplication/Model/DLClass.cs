using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace IkeaTabletopApplication.Model
{
    public class DLClass
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int E { get; set; }
        public int F { get; set; }
        public int G { get; set; }
        public int H { get; set; }
        public int I { get; set; }

        public DLClass()
        {
            A = 635;
            B = 0;
            C = 0;
            D = 0;
            E = 0;
            F = 0;
            G = 0;
            H = 0;
            I = 0;
        }

        public DLClass(int a, int b, int c, int d, int e, int f, int g, int h, int i)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;
            F = f;
            G = g;
            H = h;
            I = i;
        }
      

      
    }
}
