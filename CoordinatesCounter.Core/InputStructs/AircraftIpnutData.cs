namespace CoordinatesCounter.Core.InputStructs
{
    public class AircraftIpnutData
    {
        /// <summary>
        /// Vertical aircraft coordinate
        /// </summary>
        private float _xS;

        /// <summary>
        /// Horizontal aircraft coordinate
        /// </summary>
        private float _yS;

        /// <summary>
        /// Flight altitude
        /// </summary>
        private float _h;

        /// <summary>
        /// Vertical aircraft coordinate
        /// </summary>
        public float XS
        {
            get { return _xS; }
            set { _xS = value; }
        }

        /// <summary>
        /// Horizontal aircraft coordinate
        /// </summary>
        public float YS
        {
            get { return _yS; }
            set { _yS = value; }
        }

        /// <summary>
        /// Flight altitude
        /// </summary>
        public float H
        {
            get { return _h; }
            set { _h = value; }
        }
    }
}