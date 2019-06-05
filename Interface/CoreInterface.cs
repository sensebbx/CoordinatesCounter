using CoordinatesCounter.Core;
using CoordinatesCounter.Core.InputStructs;

namespace Interface
{
    public static class CoreInterface
    {
        public static AircraftIpnutData AircraftIpnutData;
        public static CameraInputData CameraInputData;
        public static ObjectInputData ObjectInputData;
        public static AngleCameraOnPlaneMatrix AngleCameraOnPlaneMatrix;
        public static AnglePlaneMatrix AnglePlaneMatrix;
        public static CoordinatesCounter.Core.Calculations.CoordinatesCounter CoordinatesCounter;

        static CoreInterface()
        {
        }
    }
}