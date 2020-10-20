using System.Windows;
using System.Windows.Media;


namespace UT2_Ac3_Imagen
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void opacidadAltaRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 1;
        }

        private void opacidadMediaRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 0.6;
        }

        private void opacidadBajaRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 0.3;
        }

        private void rellenoRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.Fill;
        }

        private void uniformeRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.Uniform;
        }

        private void rellenoUniformeRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.UniformToFill;
        }

        private void sinAjusteRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.None;
        }
    }
}
