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

namespace NotarialOffice
{
    /// <summary>
    /// Interaction logic for ClientiWIndow.xaml
    /// </summary>
    public partial class ClientiWIndow : Window
    {
        public ClientiWIndow()
        {
            InitializeComponent();
            dgClients.ItemsSource = NotaryDBEntities.GetContext().Clients.ToList();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            OsnovnoeMenu osnovnoe = new OsnovnoeMenu();
            osnovnoe.Show();
            clientiWindow.Close();

        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            SozdanieClienta sozdanieClienta = new SozdanieClienta();
            sozdanieClienta.ShowDialog();    
            
        }

    }
}
