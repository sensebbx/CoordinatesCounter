using System;
using Accord.Math;

namespace CoordinatesCounter.Core
{
    public class AnglePlaneMatrix
    {
        private Accord.Math.Matrix3x3 _matrix;

        public Accord.Math.Matrix3x3 Matrix
        {
            get { return _matrix; }
        }

        public AnglePlaneMatrix(double phi, double theta, double gamma)
        {
            _matrix = new Matrix3x3
            {
                V00 = (float) (Math.Cos(phi) * Math.Cos(theta)),
                V01 = (float) (Math.Sin(phi) * Math.Cos(gamma) - Math.Cos(phi) * Math.Sin(theta) * Math.Sin(gamma)),
                V02 = (float) (-Math.Sin(phi) * Math.Sin(gamma) - Math.Cos(phi) * Math.Sin(theta) * Math.Cos(gamma)),
                V10 = (float) (Math.Sin(phi) * Math.Cos(theta)),
                V11 = (float) (-Math.Cos(phi) * Math.Cos(gamma) - Math.Sin(phi) * Math.Sin(theta) * Math.Sin(gamma)),
                V12 = (float) (Math.Cos(phi)*Math.Sin(gamma) - Math.Sin(phi)*Math.Sin(theta)*Math.Cos(gamma)),
                V20 = (float) (Math.Sin(theta)),
                V21 = (float)( Math.Cos(theta)*Math.Sin(gamma)),
                V22 = (float) (Math.Cos(theta)*Math.Cos(gamma))
            };
        }
        
        
    }
}