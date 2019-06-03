namespace CoordinatesCounter.Core.InputStructs
{
    /// <summary>
    /// Contains inputs of object
    /// </summary>
    public struct ObjectInputData
    {
        /// <summary>
        /// Contains inputs of camera
        /// </summary>
        private readonly CameraInputData _cameraInputData;

        /// <summary>
        /// Vertical axis coordinate of object on image
        /// </summary>
        private int _m;

        /// <summary>
        /// Horizontal axis coordinate of object on image
        /// </summary>
        private int _n;

        /// <summary>
        /// Object height on Earth
        /// </summary>
        private float _h;


        /// <summary>
        /// Vertical axis coordinate of object in camera coordinates system
        /// </summary>
        public float Xob
        {
            get { return (float) (_cameraInputData.M - _m - 0.5) * _cameraInputData.DeltaX; }
        }

        /// <summary>
        /// Horizontal axis coordinate of object in camera coordinates system
        /// </summary>
        public float Yob
        {
            get { return (float) (_cameraInputData.N - _n - 0.5) * _cameraInputData.DeltaY; }
        }

        /// <summary>
        /// Object height on Earth
        /// </summary>
        public float Hs
        {
            get { return _h; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="cameraInputData"></param>
        /// <param name="m">Vertical axis coordinate of object on image</param>
        /// <param name="n">Horizontal axis coordinate of object on image</param>
        /// <param name="h">Object height on Earth</param>
        public ObjectInputData(ref CameraInputData cameraInputData, int m, int n, float h)
        {
            _cameraInputData = cameraInputData;
            _m = m;
            _n = n;
            _h = h;
        }
    }
}