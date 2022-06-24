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
    /// Interaction logic for ClientAcountsWindow.xaml
    /// </summary>
    public partial class DealsListWindow : Window
    {
        public DealsListWindow()
        {
            InitializeComponent();
            dgDeals.ItemsSource = NotaryDBEntities.GetContext().Deals.ToList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            SozdanieZakaza sozdanieSdelki = new SozdanieZakaza();
            sozdanieSdelki.ShowDialog();

        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            OsnovnoeMenu osnovnoeMenu = new OsnovnoeMenu();
            osnovnoeMenu.Show();
            dealsWindow.Close();
        }


    }
}
