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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project2
{
    /// <summary>
    /// Логика взаимодействия для PhonesPage.xaml
    /// </summary>
    public partial class PhonesPage : Page
    {
        public PhonesPage()
        {
            InitializeComponent();
        }

        public class Phone
        {
            public string Name { get; set; }
            public string Number { get; set; }
        }

        public List<Phone> phones = new List<Phone>();

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            PhonesGrid.Items.Add(new ListViewItem { Content = new Phone() { Name = NameTextBox.Text, Number = PhoneTextBox.Text } });
            phones.Add(new Phone() { Name = NameTextBox.Text, Number = PhoneTextBox.Text });
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < phones.Count; i++)
            {
                if (phones[i].Name == SearchTextBox.Text | phones[i].Number == SearchTextBox.Text)
                {
                    MessageBox.Show($"Найденная информация:\n {i + 1}: {phones[i].Name}:{phones[i].Number}");
                }
                else
                {
                    MessageBox.Show("Ничего не найдено");
                }
            }    
        }
    }
}
