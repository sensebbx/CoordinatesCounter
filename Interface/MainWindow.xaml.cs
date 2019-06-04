using System.Windows;

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
            //TODO: вызвать основную функцию ядра
        }

        //TODO: вызвать эту функцию из ядра для передачи результата
        public void ResultOutput(int x, int y, int h, int l)
        {
            X.Text = x.ToString();
            Y.Text = y.ToString();
            H.Text = h.ToString();
            L.Text = l.ToString();
        }
    }
}
