using System;
using System.Text.RegularExpressions;
using System.Windows;

namespace Interface
{
    /// <summary>
    /// Interaction logic for CameraParameters.xaml
    /// </summary>
    public partial class CameraParameters : Window
    {
        public CameraParameters()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            string cadrFormat = this.cadrFormat.Text;
            string cornerGrip = this.cornerGrip.Text;
            string angularPositionCam = this.angularPositionCam.Text;
            string focalLength = this.focalLength.Text;
            string matrixPeriod = this.matrixPeriod.Text;
            string snapshotFrequency = this.snapshotFrequency.Text;

            if (InputCheck.CheckInputCameraData(cadrFormat, cornerGrip, angularPositionCam, matrixPeriod))
            {
                string[] cadrFormatArr = Regex.Split(cadrFormat, @"[xх]{1}");
                string[] cornerGripArr = Regex.Split(cornerGrip, @"[xх]{1}");
                string[] angularPositionArr = angularPositionCam.Split(':');
                string[] matrixPariodArr = matrixPeriod.Split(':');

                int i = 0;
                int[] cadrFormatArrInt = new int[cadrFormatArr.Length];

                foreach (string s in cadrFormatArr)
                {
                    cadrFormatArrInt[i] = Convert.ToInt32(s);
                    ++i;
                }

                i = 0;
                int[] angularPositionArrInt = new int[angularPositionArr.Length];

                foreach (string s in angularPositionArr)
                {
                    angularPositionArrInt[i] = Convert.ToInt32(s);
                    ++i;
                }

                i = 0;
                int[] cornerGripArrInt = new int[cornerGripArr.Length];

                foreach (string s in cornerGripArr)
                {
                    cornerGripArrInt[i] = Convert.ToInt32(s);
                    ++i;
                }

                i = 0;
                int[] matrixPariodArrInt = new int[matrixPariodArr.Length];

                foreach (string s in matrixPariodArr)
                {
                    matrixPariodArrInt[i] = Convert.ToInt32(s);
                    ++i;
                }

                int focalLengthInt = Convert.ToInt32(focalLength);
                int snapshotFrequencyInt = Convert.ToInt32(snapshotFrequency);

                //TODO: передать данные в ядро
            }
        }
    }
}
