using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndRectangleLibrary
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
            _width = width + clearance + endMill;
            return _width;
        }

        public double calculateHeight(double inputThickness, double endMill)
        {
            _height = inputThickness + (endMill * 2);
            return _height;
        }

        public double calulateX1(double origin, double difference)
        {
            _X1 = origin - difference;
            return _X1;
        }

        public double calulateX2(double width, double origin, double clearance, double endMill)
        {
            _X2 = origin + width + endMill + clearance;
            return _X2;
        }

        public double calulateY1(double origin, double difference)
        {
            _Y1 = origin - difference;
            return _Y1;
        }

        public double calulateY2(double origin)
        {
            _Y2 = origin - .625;
            return _Y2;
        }

        public double[,] createRectangle1()
        {
            //x,y
            double[,] rectangleCords = new double[4,4];

            rectangleCords[0, 0] = _X1;
            rectangleCords[0, 1] = _Y1;

            rectangleCords[1, 0] = _X1 + _width;
            rectangleCords[1, 1] = _Y1;

            rectangleCords[2, 0] = _X1 + _width;
            rectangleCords[2, 1] = _Y1 + _height;

            rectangleCords[3, 0] = _X1;
            rectangleCords[3, 1] = _Y1 + _height;
           
            return rectangleCords;
        }

        public double[,] createRectangle2()
        {
            //x,y
            double[,] rectangleCords = new double[4, 4];

            rectangleCords[0, 0] = _X2;
            rectangleCords[0, 1] = _Y2;

            rectangleCords[1, 0] = _X2 + _width;
            rectangleCords[1, 1] = _Y2;

            rectangleCords[2, 0] = _X2 + _width;
            rectangleCords[2, 1] = _Y2 + _height;

            rectangleCords[3, 0] = _X2;
            rectangleCords[3, 1] = _Y2 + _height;

            return rectangleCords;
        }
    }
}
