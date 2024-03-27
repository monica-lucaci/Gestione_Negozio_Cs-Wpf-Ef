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
using wpf_GestioneNegozio.DAL;
using wpf_GestioneNegozio.Models;

namespace wpf_GestioneNegozio
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

        private void GestioneCategorie_Click(object sender, RoutedEventArgs e)
        {
            GestioneCategoria finestra = new GestioneCategoria();
            finestra.Show();
            this.Close();
        }

        private void GestioneProdotto_Click(object sender, RoutedEventArgs e)
        {
            GestioneProdotto finestra = new GestioneProdotto();
            finestra.Show();
            this.Close();
        }

        private void GestioneVariazione_Click(object sender, RoutedEventArgs e)
        {
            GestioneVariazione finestra = new GestioneVariazione();
            finestra.Show();
            this.Close();
        }

        private void GestioneUtente_Click(object sender, RoutedEventArgs e)
        {
            GestioneUtente finestra = new GestioneUtente();
            finestra.Show();
            this.Close();
        }

        private void GestioneOrdine_Click(object sender, RoutedEventArgs e)
        {
            GestioneOrdine finestra = new GestioneOrdine();
            finestra.Show();
            this.Close();
        }
    }
}