using System;
using Accord.Math;

namespace CoordinatesCounter.Core
{
    /// <summary>
    /// Contains camera angle matrix relatively to aircraft
    /// </summary>
    public class AngleCameraOnPlaneMatrix
    {
        /// <summary>
        /// Angle matrix of camera
        /// </summary>
        private Accord.Math.Matrix3x3 _matrix;

        /// <summary>
        /// Angle matrix of camera
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
        public AngleCameraOnPlaneMatrix(double phi, double theta, double gamma)
        {
            if (phi == 0 && theta == 0 && gamma == 0)
            {
                _matrix = new Matrix3x3
                {
                    V00 = (float) 1.0,
                    V01 = (float) 0.0,
                    V02 = (float) 0.0,
                    V10 = (float) 0.0,
                    V11 = (float) 1.0,
                    V12 = (float) 0.0,
                    V20 = (float) 0.0,
                    V21 = (float) 0.0,
                    V22 = (float) 1.0,
                };
                return;
            }

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