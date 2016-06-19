using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkeaTabletopApp.Model
{
    public class WidthLength
    {
        public int Width { get; set; }
        public int Length { get; set; }

        public WidthLength()
        {
            
        }

        public WidthLength(int width, int length)
        {
            Width = width;
            Length = length;
        }


    }
}
