using CoordinatesCounter.Core.InputStructs;

namespace CoordinatesCounter.Core.Calculations
{
    public class CoordinatesCounter
    {
        private AngleCameraRegEarth _angleCameraRegEarth;

        private readonly AircraftIpnutData _aircraftIpnutData;
        private readonly CameraInputData _cameraInputData;

        private float _x;
        private float _y;

        public float X
        {
            get { return _x; }
        }

        public float Y
        {
            get { return _y; }
        }

        public CoordinatesCounter(ref AnglePlaneMatrix anglePlaneMatrix,
            ref AngleCameraOnPlaneMatrix angleCameraOnPlaneMatrix,
            ref CameraInputData cameraInputData,
            ref AircraftIpnutData aircraftIpnutData)
        {
            _angleCameraRegEarth = new AngleCameraRegEarth(anglePlaneMatrix, angleCameraOnPlaneMatrix);

            _cameraInputData = cameraInputData;
            _aircraftIpnutData = aircraftIpnutData;
        }

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