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
    /// Логика взаимодействия для DobavitAgentaWindow.xaml
    /// </summary>
    public partial class SozdanieSotrudnika : Window
    {
        private Employee employee = new Employee();

        public SozdanieSotrudnika()
        {
            InitializeComponent();
            positionCombo.ItemsSource = NotaryDBEntities.GetContext().Positions.ToList();
            DataContext = employee;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(employee.FIO))
                errors.AppendLine("Поле ФИО пустое");
            if (employee.Position == null)
                errors.AppendLine("Выберите должность");
            if (string.IsNullOrWhiteSpace(employee.Education))
                errors.AppendLine("Поле образование пустое");
            if (string.IsNullOrWhiteSpace(employee.NumPass))
                errors.AppendLine("Поле номера пасспорта пустое");
            if (string.IsNullOrWhiteSpace(employee.SerialPass))
                errors.AppendLine("Поле серии пасспорта пустое");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (employee.id == 0)
            {
                NotaryDBEntities.GetContext().Employees.Add(employee);
            }
            try
            {
                NotaryDBEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                dobavitAgentaWindow.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void numBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ".")))
                e.Handled = true;
        }

        private void serBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ".")))
                e.Handled = true;
        }
    }
}
