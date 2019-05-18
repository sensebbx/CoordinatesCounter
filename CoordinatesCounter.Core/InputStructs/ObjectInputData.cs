namespace CoordinatesCounter.Core.InputStructs
{
    public struct ObjectInputData
    {
        private readonly CameraInputData _cameraInputData;
        private int _m;
        private int _n;
        private float _h;


        public float Xob
        {
            get { return (float) (_cameraInputData.M - _m - 0.5) * _cameraInputData.DeltaX; }
        }

        public float Yob
        {
            get { return (float) (_cameraInputData.N - _n - 0.5) * _cameraInputData.DeltaY; }
        }

        public float Hs
        {
            get { return _h; }
        }

        public ObjectInputData(ref CameraInputData cameraInputData, int m, int n, float h)
        {
            _cameraInputData = cameraInputData;
            _m = m;
            _n = n;
            _h = h;
        }
    }
}