﻿using System;
using System.Windows;
using CoordinatesCounter.Core;
using CoordinatesCounter.Core.InputStructs;

namespace Interface
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class LAParameters : Window
    {
        public LAParameters()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            string flightHeigh = this.flightHeigh.Text;
            string flightHeighChange = this.flightHeighChange.Text;
            string speedProection = this.speedProection.Text;
            string angularPositionLA = this.angularPositionLA.Text;

            if (InputCheck.CheckInputLAData(flightHeighChange, speedProection, angularPositionLA))
            {
                string[] speedProectionArr = speedProection.Split(':');
                string[] angularPositionLAArr = angularPositionLA.Split(':');

                int i = 0;
                int[] speedProectionArrInt = new int[speedProectionArr.Length];

                foreach (string s in speedProectionArr)
                {
                    speedProectionArrInt[i] = Convert.ToInt32(s);
                    ++i;
                }

                i = 0;
                int[] angularPositionLAArrInt = new int[angularPositionLAArr.Length];

                foreach (string s in angularPositionLAArr)
                {
                    angularPositionLAArrInt[i] = Convert.ToInt32(s);
                    ++i;
                }

                int flightHeighInt = Convert.ToInt32(flightHeigh);
                int flightHeighChangeInt = Convert.ToInt32(flightHeighChange);


                //Input of AircraftItselt
                CoreInterface.AircraftIpnutData = new AircraftIpnutData();
                CoreInterface.AircraftIpnutData.H = flightHeighInt;
                CoreInterface.AircraftIpnutData.VX = speedProectionArrInt[0];
                CoreInterface.AircraftIpnutData.VY = speedProectionArrInt[1];

                //TODO: Координаты самолёта нужны

                //Input of Aircraft Matrix
                CoreInterface.AnglePlaneMatrix = new AnglePlaneMatrix(angularPositionLAArrInt[0], angularPositionLA[1],
                    angularPositionLA[2]);


                Close();
            }
        }
    }
}