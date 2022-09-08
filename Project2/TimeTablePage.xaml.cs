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
    public partial class TimeTablePage : Page
    {
        public TimeTablePage()
        {
            InitializeComponent();
        }

        public class TimeTable
        {
            public string Name { get; set; }
            public string Work { get; set; }

            public string Time { get; set; }
        }

        public List<TimeTable> timeTable = new List<TimeTable>();


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            PhonesGrid.Items.Add(new ListViewItem { Content = new TimeTable() { Name = NameTextBox.Text, Work = WorkTextBox.Text, Time = TimeTextBox.Text } });
            timeTable.Add(new TimeTable() { Name = NameTextBox.Text, Work = WorkTextBox.Text, Time = TimeTextBox.Text });
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < timeTable.Count; i++)
            {
                if (timeTable[i].Name == SearchTextBox.Text | timeTable[i].Work == SearchTextBox.Text | timeTable[i].Time == SearchTextBox.Text)
                {
                    MessageBox.Show($"Найденная информация:\n {i + 1}: {timeTable[i].Name}:{timeTable[i].Work}:{timeTable[i].Time}");
                }
                else
                {
                    MessageBox.Show("Ничего не найдено");
                }
            }
        }
    }
}
