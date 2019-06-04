namespace CoordinatesCounter.Core.InputStructs
{
    public struct CameraInputData
    {
        /// <summary>
        /// Vertical size of camera matrix
        /// </summary>
        public float M { get; }

        /// <summary>
        /// Horizontal size of camera matrix
        /// </summary>
        public float N { get; }

        /// <summary>
        /// Distance between two pixels on vertical axis
        /// </summary>
        public float DeltaX { get; }

        /// <summary>
        /// Distance between two pixels on horizontal axis
        /// </summary>
        public float DeltaY { get; }

        /// <summary>
        /// Focal length of camera
        /// </summary>
        public float F { get; }

        /// <summary>
        /// Vertical axis coordinate of the center of camera
        /// </summary>
        public float X0 { get; }

        /// <summary>
        /// Horizontal axis coordinate of the center of camera
        /// </summary>
        public float Y0 { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="m">Vertical size of camera matrix</param>
        /// <param name="n">Horizontal size of camera matrix</param>
        /// <param name="deltaX">Distance between two pixels on vertical axis</param>
        /// <param name="deltaY">Distance between two pixels on horizontal axis</param>
        /// <param name="f">Focal length of camera</param>
        public CameraInputData(float m, float n, float deltaX, float deltaY, float f)
        {
            M = m;
            N = n;
            DeltaX = deltaX;
            DeltaY = deltaY;
            F = f;

            X0 = ((M - M / 2 - (float) 0.5) * DeltaX);
            Y0 = ((N - N / 2 - (float) 0.5) * DeltaY);
        }
    }
}