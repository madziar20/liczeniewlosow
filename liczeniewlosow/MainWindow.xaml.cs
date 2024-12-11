using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace liczeniewlosow
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

        public class Glowa
        {
            private double wysokoscczola;
            private double gestoscwlosow;
            private double obowd;

            public void uzupelnijdane(double wysokoscczola, double obwod, double gestoscwlosow)
            {
                this.gestoscwlosow = gestoscwlosow;
                this.obowd = obwod;
                this.wysokoscczola = wysokoscczola;
            }

            public double ilewlosow()
            {
                double powierzchnia = obowd * wysokoscczola;
                return gestoscwlosow * powierzchnia;
            }

            private const double srednialiczbawlosow = 100000;

            public double roznica()
            {
                double liczbaWlosow = ilewlosow();
                return ((liczbaWlosow - srednialiczbawlosow) / srednialiczbawlosow) * 100;
            }

        }

        private void potwierdz_Click(object sender, RoutedEventArgs e)
        {
            Glowa glowa = new Glowa();

            glowa.uzupelnijdane(int.Parse(gestosc.Text), int.Parse(obwod.Text), int.Parse(wysokosc.Text));
            double liczbawlosow = glowa.ilewlosow();

            double roznica = glowa.roznica();
            MessageBox.Show($"szacowana ilosc wlosow: {liczbawlosow} Różnica : {roznica} %");
        }

        private void resetuj_Click(object sender, RoutedEventArgs e)
        {
            gestosc.Text = "";
            obwod.Text = "";
            wysokosc.Text = "";
        }
    }
}