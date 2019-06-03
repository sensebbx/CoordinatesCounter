using System.Collections.Generic;
using CoordinatesCounter.Core.InputStructs;

namespace CoordinatesCounter.Core.Calculations
{
    /// <summary>
    /// Contains main calculating functions
    /// </summary>
    public class CoordinatesCounter
    {
        /// <summary>
        /// Contains final camera coordinates relatively to Earth
        /// </summary>
        private AngleCameraRegEarth _angleCameraRegEarth;

        /// <summary>
        /// Contains aircraft parameters
        /// </summary>
        private readonly AircraftIpnutData _aircraftIpnutData;

        /// <summary>
        /// Contains camera parameters
        /// </summary>
        private readonly CameraInputData _cameraInputData;

        /// <summary>
        /// Output of agorithm, Y coordinate of object in "CK-90"
        /// </summary>
        private float _x;

        /// <summary>
        /// Output of algorithm, Y coordinate of object in  "CK-90"
        /// </summary>
        private float _y;

        /// <summary>
        /// X coordinate of object in "CK-90"
        /// </summary>
        public float X
        {
            get { return _x; }
        }

        /// <summary>
        /// Y coordinate of object in "CK-90"
        /// </summary>
        public float Y
        {
            get { return _y; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="anglePlaneMatrix">Contains plane angle matrix</param>
        /// <param name="angleCameraOnPlaneMatrix">Contains camera angle matrix</param>
        /// <param name="cameraInputData">Contains camera input parameters</param>
        /// <param name="aircraftIpnutData">Contains aircraft input parameters</param>
        public CoordinatesCounter(ref AnglePlaneMatrix anglePlaneMatrix,
            ref AngleCameraOnPlaneMatrix angleCameraOnPlaneMatrix,
            ref CameraInputData cameraInputData,
            ref AircraftIpnutData aircraftIpnutData)
        {
            _angleCameraRegEarth = new AngleCameraRegEarth(anglePlaneMatrix, angleCameraOnPlaneMatrix);

            _cameraInputData = cameraInputData;
            _aircraftIpnutData = aircraftIpnutData;
        }

        /// <summary>
        /// Main core function that calculating coordinates of objects
        /// </summary>
        /// <param name="objectInputData">Input object data</param>
        public void Calculate(ObjectInputData objectInputData)
        {
            _x = (float) (_aircraftIpnutData.XS -
                          (_aircraftIpnutData.H - objectInputData.Hs) *
                          ((objectInputData.Xob - _cameraInputData.X0) * _angleCameraRegEarth.Matrix.V00 +
                           (objectInputData.Yob - _cameraInputData.Y0) * _angleCameraRegEarth.Matrix.V01 -
                           _cameraInputData.F * _angleCameraRegEarth.Matrix.V02) /
                          ((objectInputData.Xob - _cameraInputData.X0) * _angleCameraRegEarth.Matrix.V20 +
                           (objectInputData.Yob - _cameraInputData.Y0) * _angleCameraRegEarth.Matrix.V21 -
                           _cameraInputData.F * _angleCameraRegEarth.Matrix.V22));
            _y = (float) (_aircraftIpnutData.XS -
                          (_aircraftIpnutData.H - objectInputData.Hs) *
                          ((objectInputData.Xob - _cameraInputData.X0) * _angleCameraRegEarth.Matrix.V10 +
                           (objectInputData.Yob - _cameraInputData.Y0) * _angleCameraRegEarth.Matrix.V11 -
                           _cameraInputData.F * _angleCameraRegEarth.Matrix.V12) /
                          ((objectInputData.Xob - _cameraInputData.X0) * _angleCameraRegEarth.Matrix.V20 +
                           (objectInputData.Yob - _cameraInputData.Y0) * _angleCameraRegEarth.Matrix.V21 -
                           _cameraInputData.F * _angleCameraRegEarth.Matrix.V22));
        }
    }
}