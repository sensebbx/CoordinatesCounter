using System;
using Accord.Math;

namespace CoordinatesCounter.Core
{
    /// <summary>
    /// Contains camera angle matrix relatively to Earth
    /// </summary>
    public class AngleCameraRegEarth
    {
        /// <summary>
        /// Angle matrix of camera relatively Earth
        /// </summary>
        private Matrix3x3 _matrix;

        /// <summary>
        /// Angle matrix of camera relatively Earth
        /// </summary>
        public Matrix3x3 Matrix
        {
            get { return _matrix; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="planeMatrix">Angle matrix class of aircraft</param>
        /// <param name="cameraOnPlaneMatrix">Angle matrix class of camera</param>
        public AngleCameraRegEarth(AnglePlaneMatrix planeMatrix, AngleCameraOnPlaneMatrix cameraOnPlaneMatrix)
        {
            _matrix = planeMatrix.Matrix * cameraOnPlaneMatrix.Matrix;
        }
    }
}