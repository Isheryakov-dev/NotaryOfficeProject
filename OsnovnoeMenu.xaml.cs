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
    /// Interaction logic for GlavnoeMenu.xaml
    /// </summary>
    public partial class OsnovnoeMenu : Window
    {
        public OsnovnoeMenu()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();   
            mainWindow.Show();
            glWindow.Close();
        }

        private void clientsInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            ClientiWIndow clWindow = new ClientiWIndow();
            clWindow.Show();
            glWindow.Close();
        }


        private void AgBtn_Click(object sender, RoutedEventArgs e)
        {
            SotrudnikiWindow agWindow = new SotrudnikiWindow();
            agWindow.Show();
            glWindow.Close();
        }



        private void contractsBN_Click(object sender, RoutedEventArgs e)
        {
            DealsListWindow contractsWindow = new DealsListWindow();
            contractsWindow.Show();
            glWindow.Close();
        }
    }
}
