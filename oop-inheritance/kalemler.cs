using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_inheritance
{
    internal class kalemler
    {
        public string pencilColor;
        public int price;
        public string brand;
        private string penOrPencil;

        public string pencilType()
        {
            return penOrPencil;
        }

        public void setPen(string penType)
        {
            this.penOrPencil = penType;
        }
    }
}
