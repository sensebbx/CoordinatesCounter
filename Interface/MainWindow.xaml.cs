using System.Windows;
using CoordinatesCounter.Core;
using CoordinatesCounter.Core.InputStructs;
using CoordinatesCounter = CoordinatesCounter.Core.Calculations.CoordinatesCounter;

namespace Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void laparam_OnClick(object sender, RoutedEventArgs e)
        {
            LAParameters win = new LAParameters();
            win.Show();
        }

        private void camparam_OnClick(object sender, RoutedEventArgs e)
        {
            CameraParameters win = new CameraParameters();
            win.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CoreInterface.CoordinatesCounter = new global::CoordinatesCounter.Core.Calculations.CoordinatesCounter(
                ref CoreInterface.AnglePlaneMatrix,
                ref CoreInterface.AngleCameraOnPlaneMatrix,
                ref CoreInterface.CameraInputData,
                CoreInterface.AircraftIpnutData);

            CoreInterface.CoordinatesCounter.Calculate(CoreInterface.ObjectInputData);

            ResultOutput(
                CoreInterface.CoordinatesCounter.X,
                CoreInterface.CoordinatesCounter.Y,
                100,
                CoreInterface.CoordinatesCounter.L);
        }

        public void ResultOutput(float x, float y, int h, float l)
        {
            X.Text = x.ToString();
            Y.Text = y.ToString();
            H.Text = h.ToString();
            L.Text = l.ToString();
        }
    }
}