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
    public partial class MeetingsPage : Page
    {
        public MeetingsPage()
        {
            InitializeComponent();
        }

        public class Meeting
        {
            public string Name { get; set; }
            public string Meet { get; set; }
        }

        public List<Meeting> Meetings = new List<Meeting>();

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            PhonesGrid.Items.Add(new ListViewItem { Content = new Meeting() { Name = NameTextBox.Text, Meet = MeetingTextBox.Text } });
            Meetings.Add(new Meeting() { Name = NameTextBox.Text, Meet = MeetingTextBox.Text });
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Meetings.Count; i++)
            {
                if (Meetings[i].Name == SearchTextBox.Text | Meetings[i].Meet == SearchTextBox.Text)
                {
                    MessageBox.Show($"Найденная информация:\n {i + 1}: {Meetings[i].Name}:{Meetings[i].Meet}");
                }
                else
                {
                    MessageBox.Show("Ничего не найдено");
                }
            }
        }
    }
}
