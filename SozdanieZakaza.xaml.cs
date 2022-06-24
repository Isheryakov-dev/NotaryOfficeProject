using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NotarialOffice
{
    /// <summary>
    /// Interaction logic for DobavlenieCourseWindow.xaml
    /// </summary>
    public partial class SozdanieZakaza : Window
    {
        private Deal _deal = new Deal();

        public SozdanieZakaza()
        {
            InitializeComponent();
            _deal.DealDate = DateTime.Now;
            DataContext = _deal;
            serviceCombo.ItemsSource = NotaryDBEntities.GetContext().Services.ToList();
            clientCombo.ItemsSource = NotaryDBEntities.GetContext().Clients.ToList();
            employeeCombo.ItemsSource = NotaryDBEntities.GetContext().Employees.ToList();
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (_deal.Service == null)
                errors.AppendLine("Выберите услугу");
            if (_deal.Client == null)
                errors.AppendLine("Выберите клиента");
            if (_deal.Employee == null)
                errors.AppendLine("Выберите сотрудника");
            
            
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_deal.id == 0)
            {
                NotaryDBEntities.GetContext().Deals.Add(_deal);
            }
            try
            {
                NotaryDBEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                dobavitCourseWindow.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        private void sumBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ".")))
                e.Handled = true;
        }

        private void yearsBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ".")))
                e.Handled = true;
        }

        private void serviceCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sumBox.Text = _deal.Service.ServicePrice.ToString();
        }
    }
}
