namespace CoordinatesCounter.Core.InputStructs
{
    public class AircraftIpnutData
    {
        private float _xS;
        private float _yS;
        private float _h;

        public float XS
        {
            get { return _xS; }
            set { _xS = value; }
        }

        public float YS
        {
            get { return _yS; }
            set { _yS = value; }
        }

        public float H
        {
            get { return _h; }
            set { _h = value; }
        }
    }
}