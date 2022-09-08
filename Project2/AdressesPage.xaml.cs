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
    public partial class AdressesPage : Page
    {
        public AdressesPage()
        {
            InitializeComponent();
        }

        public class Adress
        {
            public string Name { get; set; }
            public string Adres { get; set; }
        }

        public List<Adress> adress = new List<Adress>();


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            PhonesGrid.Items.Add(new ListViewItem { Content = new Adress() { Name = NameTextBox.Text, Adres = AdressTextBox.Text } });
            adress.Add(new Adress() { Name = NameTextBox.Text, Adres = AdressTextBox.Text });
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < adress.Count; i++)
            {
                if (adress[i].Name == SearchTextBox.Text | adress[i].Adres == SearchTextBox.Text)
                {
                    MessageBox.Show($"Найденная информация:\n {i + 1}: {adress[i].Name}:{adress[i].Adres}");
                }
                else
                {
                    MessageBox.Show("Ничего не найдено");
                }
            }
        }
    }
}
