using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndPinLibrary
{
    public class EndRectangle
    {
        public double _width { get; set; }
        public double _height { get; set; }
        public double _X1 { get; set; }
        public double _X2 { get; set; }
        public double _Y1 { get; set; }
        public double _Y2 { get; set; }

        public double calculateWidth(double width, double clearance, double endMill)
        {
            return _width = width + clearance + endMill;
        }

        public double calculateHeight(double inputThickness, double endMill)
        {
            return _height = inputThickness + (endMill * 2);
        }

        public double calulateX1(double origin)
        {
            return _X1 = origin - .625;
        }

        public double calulateX2(double width, double origin, double clearance, double endMill)
        {
            return _X2 = origin + (width + endMill + clearance);
        }

        public double calulateY1(double origin)
        {
            return _Y1 = origin - .625;
        }

        public double calulateY2(double origin)
        {
            return _Y2 = origin - .625;
        }
    }
}
