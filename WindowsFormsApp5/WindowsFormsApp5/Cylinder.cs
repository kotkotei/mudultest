using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
   public class Cylinder
    {
        public double Cylindervolume(double h,  double r)
        {
            double s = Math.PI*Math.Pow(r,2) * h;
            return s;
        }
    }
}
