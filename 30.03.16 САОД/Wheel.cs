using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Design;

namespace пирамида
{
    class Wheel
    {
        
        
        int type;
        Color clRR;
        public Wheel(int Type)
        {
            if (Type > 0)
            {
                this.type = Type;
                clRR = Color.FromArgb(65);
            }
        }
        
        public int Type
        {
            get
            { return type; }
            
        
        }
        public Color ClRR
        {
            get
            { return clRR; }
        }
        
    }
}
