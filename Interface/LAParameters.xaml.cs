using System;
using System.Windows;

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
            string LACoordinates = this.LACoordinates.Text;

            if (InputCheck.CheckInputLAData(flightHeighChange, speedProection, angularPositionLA, LACoordinates))
            {
                string[] speedProectionArr = speedProection.Split(':');
                string[] angularPositionLAArr = angularPositionLA.Split(':');
                string[] LACoordinatesArr = LACoordinates.Split(':');

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

                i = 0;
                int[] LACoordinatesArrInt = new int[LACoordinatesArr.Length];

                foreach (string s in LACoordinatesArr)
                {
                    LACoordinatesArrInt[i] = Convert.ToInt32(s);
                    ++i;
                }

                int flightHeighInt = Convert.ToInt32(flightHeigh);
                int flightHeighChangeInt = Convert.ToInt32(flightHeighChange);

                //TODO: передать данные в ядро

                Close();
            }
        }
    }
}
