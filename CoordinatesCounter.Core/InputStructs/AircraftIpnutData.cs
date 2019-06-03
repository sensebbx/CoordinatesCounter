using System;

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
        /// X axis velocity of aircraft
        /// </summary>
        private float _vX;

        /// <summary>
        /// Y axis velocity of aircraft
        /// </summary>
        private float _vY;

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

        /// <summary>
        /// X axis velocity of aircraft
        /// </summary>
        public float VX
        {
            get { return _vX; }
            set { _vX = value; }
        }

        /// <summary>
        /// Y axis velocity of aircraft
        /// </summary>
        public float VY
        {
            get { return _vY; }
            set { _vY = value; }
        }

        /// <summary>
        /// Velocity of aircraft
        /// </summary>
        public float Velocity
        {
            get { return (float) Math.Sqrt(_vX * _vX + _vY * _vY); }
        }
    }
}