using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticaPerimetros
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            controlPerimetroCirculo.Visibility = Visibility.Collapsed;
            controlPerimetroCuadrado.Visibility = Visibility.Collapsed;
            controlPerimetroTrapecio.Visibility = Visibility.Collapsed;
            controlPerimetroRectangulo.Visibility = Visibility.Collapsed;

            switch (cbTipoFigura.SelectedIndex)
            {
                case 0: //Círculo
                    controlPerimetroCirculo.Visibility = Visibility.Visible;
                    break;
                case 1: //Cuadrado
                    controlPerimetroCuadrado.Visibility = Visibility.Visible;
                    break;
                case 2: //Trapecio
                    controlPerimetroTrapecio.Visibility = Visibility.Visible;
                    break;
                case 3: //Rectángulo
                    controlPerimetroRectangulo.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            float perimetro = 0.0f;

            switch (cbTipoFigura.SelectedIndex)
            {
                case 0: //Círculo
                    float radio = float.Parse(controlPerimetroCirculo.txtRadio.Text);
                    perimetro = 2 * radio * 3.14159f;
                    break;
                case 1: //Cuadrado
                    float lado = float.Parse(controlPerimetroCuadrado.txtLado.Text);
                    perimetro = lado * 4;
                    break;
                case 2: //Trapecio
                    float lado1 = float.Parse(controlPerimetroTrapecio.txtLadoTrapecio1.Text);
                    float lado2 = float.Parse(controlPerimetroTrapecio.txtLadoTrapecio2.Text);
                    float lado3 = float.Parse(controlPerimetroTrapecio.txtLadoTrapecio3.Text);
                    float lado4 = float.Parse(controlPerimetroTrapecio.txtLadoTrapecio4.Text);
                    perimetro = lado1 + lado2 + lado3 + lado4;
                    break;
                case 3: //Rectangulo
                    float baseRectangulo = float.Parse(controlPerimetroRectangulo.txtBaseRectangulo.Text);
                    float alturaRectangulo = float.Parse(controlPerimetroRectangulo.txtAlturaRectangulo.Text);
                    perimetro = (baseRectangulo * 2) + (alturaRectangulo * 2);
                    break;
                default:
                    break;
            }
            txtPerimetro.Text = perimetro.ToString();
        }
    }
}
