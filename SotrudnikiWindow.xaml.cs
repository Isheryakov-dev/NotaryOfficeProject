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
    /// Interaction logic for CurrencyCoursesWindow.xaml
    /// </summary>
    public partial class SotrudnikiWindow : Window
    {
        public SotrudnikiWindow()
        {
            InitializeComponent();
            dgSotrudniki.ItemsSource = NotaryDBEntities.GetContext().Employees.ToList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            SozdanieSotrudnika sozdanieSotrudnika = new SozdanieSotrudnika();
            sozdanieSotrudnika.ShowDialog();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            OsnovnoeMenu osnovnoeMenu = new OsnovnoeMenu();
            osnovnoeMenu.Show();
            sotrudnikiWindow.Close();
        }
    }
}
