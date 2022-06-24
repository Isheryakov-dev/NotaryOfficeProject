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
    /// Interaction logic for DobavitClientaWindow.xaml
    /// </summary>
    public partial class SozdanieClienta : Window
    {
        private Client _client = new Client();

        public SozdanieClienta()
        {
            InitializeComponent();
            _client.BirthdayDate = DateTime.Now;
            DataContext = _client;
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_client.FIO))
                errors.AppendLine("Укажите ФИО");
            if (string.IsNullOrWhiteSpace(_client.Address))
                errors.AppendLine("Укажите адрес");
            if (string.IsNullOrWhiteSpace(_client.NumPass))
                errors.AppendLine("Укажите номер пасспорта");
            if (string.IsNullOrWhiteSpace(_client.SerPass))
                errors.AppendLine("Укажите серию пасспорта");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_client.id == 0)
            {
                NotaryDBEntities.GetContext().Clients.Add(_client);
            }
            try
            {
                NotaryDBEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                dobavitClientaWindow.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        

        private void serBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ".")))
                e.Handled = true;
        }

        private void numBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ".")))
                e.Handled = true;
        }
    }
    
}
