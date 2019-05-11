using System;
using Accord.Math;

namespace CoordinatesCounter.Core
{
    public class AngleCameraRegEarth
    {
        private Matrix3x3 _matrix;

        public Matrix3x3 Matrix
        {
            get { return _matrix; }
        }

        public AngleCameraRegEarth(AnglePlaneMatrix planeMatrix, AngleCameraOnPlaneMatrix cameraOnPlaneMatrix)
        {
            _matrix = planeMatrix.Matrix * cameraOnPlaneMatrix.Matrix;
        }
    }
}