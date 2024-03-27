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
using System.Windows.Shapes;
using wpf_GestioneNegozio.DAL;
using wpf_GestioneNegozio.Models;

namespace wpf_GestioneNegozio
{
    /// <summary>
    /// Logica di interazione per GestioneProdotto.xaml
    /// </summary>
    public partial class GestioneProdotto : Window
    {
        public GestioneProdotto()
        {
            InitializeComponent();
        }

       

        private void btnSalvaProdotto_Click(object sender, RoutedEventArgs e)
        {
            string nomeProdotto = tbNomeProdotto.Text;
            string descrizioneProdotto = tbDescrizioneProdotto.Text;
            int idCategoria = Convert.ToInt32(tbIdCategoria.Text);

            Prodotto nuovoProdotto = new Prodotto()
            {
                Nome = nomeProdotto,
                Descrizione = descrizioneProdotto,
                CategoriaRif = idCategoria
            };

            if (ProdottoDal.GetInstance().Insert(nuovoProdotto))
            {
                MessageBox.Show("Prodotto inserito con successo");
                dgProdotti.ItemsSource = ProdottoDal.GetInstance().GetAll();
            }
            else
            {
                MessageBox.Show("Errore durante l'inserimento del prodotto");
            }

            tbNomeProdotto.Text = "";
            tbDescrizioneProdotto.Text = "";
            tbIdCategoria.Text = "";
        }

        private void btnAggiornaProdotto_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancellaProdotto_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tbDescrizioneProdotto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbIdCategoria_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbNomeProdotto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbIdProdotto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbNuovoNomeProdotto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbIdProdottoCancella_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
              MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();   
        }
    }
}
