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
        private int _m1;

        /// <summary>
        /// Horizontal axis coordinate of object on image
        /// </summary>
        private int _n1;

        /// <summary>
        /// Vertical axis coordinate of object on image
        /// </summary>
        private int _m2;

        /// <summary>
        /// Horizontal axis coordinate of object on image
        /// </summary>
        private int _n2;

        /// <summary>
        /// Object height on Earth
        /// </summary>
        private float _h;


        /// <summary>
        /// Vertical axis coordinate of object in camera coordinates system
        /// </summary>
        public float Xob1
        {
            get { return (float) (_cameraInputData.M - _m1 - 0.5) * _cameraInputData.DeltaX; }
        }

        /// <summary>
        /// Horizontal axis coordinate of object in camera coordinates system
        /// </summary>
        public float Yob1
        {
            get { return (float) (_cameraInputData.N - _n1 - 0.5) * _cameraInputData.DeltaY; }
        }

        /// <summary>
        /// Vertical axis coordinate of object in camera coordinates system
        /// </summary>       
        public float Xob2
        {
            get { return (float) (_cameraInputData.M - _m2 - 0.5) * _cameraInputData.DeltaX; }
        }

        /// <summary>
        /// Horizontal axis coordinate of object in camera coordinates system
        /// </summary>
        public float Yob2
        {
            get { return (float) (_cameraInputData.N - _n2 - 0.5) * _cameraInputData.DeltaY; }
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
        /// <param name="cameraInputData">Camera data</param>
        /// <param name="m1">Vertical axis coordinate of object</param>
        /// <param name="n1">Horizontal axis coordinate of object</param>
        /// <param name="m2">Vertical axis coordinate of object</param>
        /// <param name="n2">Horizontal axis coordinate of object</param>
        /// <param name="h">Object height on Earth</param>
        public ObjectInputData(ref CameraInputData cameraInputData, int m1, int n1, int m2, int n2, float h)
        {
            _cameraInputData = cameraInputData;
            _m1 = m1;
            _n1 = n1;
            _m2 = m2;
            _n2 = n2;
            _h = h;
        }
    }
}