using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using CoordinatesCounter.Core;
using CoordinatesCounter.Core.InputStructs;

namespace Interface
{
    /// <summary>
    /// Interaction logic for CameraParameters.xaml
    /// </summary>
    public partial class CameraParameters : Window
    {
        private string _filename;

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
            List<string> pairOfCoordinates = new List<string>();

            try
            {
                pairOfCoordinates = ReadCoordinatesFile(_filename);
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите файл с координатами объекта", "Ошибка ввода", MessageBoxButton.OK,
                    MessageBoxImage.Error);

                return;
            }


            if (InputCheck.CheckInputCameraData(cadrFormat, cornerGrip, angularPositionCam, matrixPeriod,
                pairOfCoordinates))
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

                List<KeyValuePair<int, int>> pairOfCoordinatesInt = new List<KeyValuePair<int, int>>();

                foreach (string pairOfCoordinate in pairOfCoordinates)
                {
                    string[] temp = pairOfCoordinate.Split(';');

                    pairOfCoordinatesInt.Add(new KeyValuePair<int, int>(Convert.ToInt32(temp[0]),
                        Convert.ToInt32(temp[1])));
                }

                int focalLengthInt = Convert.ToInt32(focalLength);
                int snapshotFrequencyInt = Convert.ToInt32(snapshotFrequency);

                //Input of camera parameters itself
                CoreInterface.CameraInputData = new CameraInputData(
                    (float) cadrFormatArrInt[0],
                    (float) cadrFormatArrInt[1],
                    (float) matrixPariodArrInt[0],
                    (float) matrixPariodArrInt[1],
                    (float) focalLengthInt);

                //Input of camera angles
                CoreInterface.AngleCameraOnPlaneMatrix = new AngleCameraOnPlaneMatrix(
                    angularPositionArrInt[0],
                    angularPositionArrInt[1],
                    angularPositionArrInt[2]);

                //Input of object data
                CoreInterface.ObjectInputData = new ObjectInputData(
                    ref CoreInterface.CameraInputData,
                    pairOfCoordinatesInt[0].Key,
                    pairOfCoordinatesInt[0].Value,
                    pairOfCoordinatesInt[1].Key,
                    pairOfCoordinatesInt[1].Value,
                    100);

                Close();
            }
        }

        private List<string> ReadCoordinatesFile(string filename)
        {
            List<string> result = new List<string>();

            StreamReader fstream = new StreamReader(filename);

            using (fstream)
            {
                string pairOfCoordinates;

                while (!fstream.EndOfStream)
                {
                    pairOfCoordinates = fstream.ReadLine();
                    result.Add(pairOfCoordinates);
                }
            }

            return result;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "Text documents (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 2;

            Nullable<bool> result = dialog.ShowDialog();

            if (result == true)
            {
                _filename = dialog.FileName;
                coordinatesFile.Text = _filename;
            }
        }
    }
}