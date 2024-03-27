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
    /// Logica di interazione per GestioneCategoria.xaml
    /// </summary>
    public partial class GestioneCategoria : Window
    {
        public GestioneCategoria()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, RoutedEventArgs e)
        {
            string? nom = this.tbNome.Text;

            Categorium temp = new Categorium()
            {
                Nome = nom,
            };

            if (CategoriumDal.getIstance().Insert(temp))
            {
                MessageBox.Show("inserito");
                dgCategoria.ItemsSource = CategoriumDal.getIstance().GetAll(); ;
            }

            else
                MessageBox.Show("errore di inserimento");

            this.tbNome.Text = "";
        }

        private void tbNome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnAggiorna_Click(object sender, RoutedEventArgs e)
        {
            string nom = this.tbNomeCat.Text;
            int id = Convert.ToInt32(this.tbId.Text);

            Categorium temp = new Categorium()
            {
                Nome = nom,
                CategoriaId = id
            };

            if (CategoriumDal.getIstance().Update(temp))
            {
                MessageBox.Show("Aggiornato");
                dgCategoria.ItemsSource = CategoriumDal.getIstance().GetAll();
            }
            else
            {
                MessageBox.Show("Errore di aggiornamento");
            }

            this.tbNomeCat.Text = "";
            this.tbId.Text = "";
        }

        private void btnCancella_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(this.tbId2.Text);

            if (CategoriumDal.getIstance().Delete(id))
            {
                MessageBox.Show("Categoria eliminata");
                dgCategoria.ItemsSource = CategoriumDal.getIstance().GetAll();
            }
            else
            {
                MessageBox.Show($"Errore durante l'eliminazione della categoria con ID {id}");
            }


            this.tbId.Text = "";

        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();   
        }
    }
}
