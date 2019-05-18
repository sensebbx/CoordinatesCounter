namespace CoordinatesCounter.Core.InputStructs
{
    public struct CameraInputData
    {
        public float M { get; }
        public float N { get; }
        public float DeltaX { get; }
        public float DeltaY { get; }

        public float F { get; }

        public float X0 { get; }
        public float Y0 { get; }

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