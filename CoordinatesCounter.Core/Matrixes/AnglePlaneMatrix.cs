using System;
using Accord.Math;

namespace CoordinatesCounter.Core
{
    /// <summary>
    /// Gets angle coordinates of plane and calculates its angle matrix
    /// </summary>
    public class AnglePlaneMatrix
    {
        /// <summary>
        /// Matrix container
        /// </summary>
        private Accord.Math.Matrix3x3 _matrix;

        /// <summary>
        /// Matrix container for calculations
        /// </summary>
        public Accord.Math.Matrix3x3 Matrix
        {
            get { return _matrix; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="phi">Angle coordinate</param>
        /// <param name="theta">Angle coordinate</param>
        /// <param name="gamma">Angle coordinate</param>
        public AnglePlaneMatrix(double phi, double theta, double gamma)
        {
            _matrix = new Matrix3x3
            {
                V00 = (float) (Math.Cos(phi) * Math.Cos(theta)),
                V01 = (float) (Math.Sin(phi) * Math.Cos(gamma) - Math.Cos(phi) * Math.Sin(theta) * Math.Sin(gamma)),
                V02 = (float) (-Math.Sin(phi) * Math.Sin(gamma) - Math.Cos(phi) * Math.Sin(theta) * Math.Cos(gamma)),
                V10 = (float) (Math.Sin(phi) * Math.Cos(theta)),
                V11 = (float) (-Math.Cos(phi) * Math.Cos(gamma) - Math.Sin(phi) * Math.Sin(theta) * Math.Sin(gamma)),
                V12 = (float) (Math.Cos(phi) * Math.Sin(gamma) - Math.Sin(phi) * Math.Sin(theta) * Math.Cos(gamma)),
                V20 = (float) (Math.Sin(theta)),
                V21 = (float) (Math.Cos(theta) * Math.Sin(gamma)),
                V22 = (float) (Math.Cos(theta) * Math.Cos(gamma))
            };
        }
    }
}