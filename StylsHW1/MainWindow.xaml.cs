using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace StylsHW1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<UserControl1> items;
        public MainWindow()
        {
            InitializeComponent();
            items = new ObservableCollection<UserControl1>();
            itemsList.ItemsSource = items;
        }
        private void Changes()
        {
            itemsList.ItemsSource = null;
            itemsList.ItemsSource = items;
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (itemsList.SelectedItem == null)
            {
                items.Add(new UserControl1(Changes));
            }
            else
            {
                int count;
                if (int.TryParse(countTextBox.Text, out count))
                {
                    (itemsList.SelectedItem as UserControl1).Count += count;
                }
                else
                {
                    MessageBox.Show("Введите корректное число");
                }
            }
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (itemsList.SelectedItem != null)
            {
                items.Remove(itemsList.SelectedItem as UserControl1);
            }
        }
        private void DeleteButton1_Click(object sender, RoutedEventArgs e)
        {
            if (itemsList.SelectedItem != null)
            {
                int count;
                if (int.TryParse(countTextBox.Text, out count))
                {
                    if ((itemsList.SelectedItem as UserControl1).Count - count >= 0)
                    {
                        (itemsList.SelectedItem as UserControl1).Count -= count;
                    }
                    else
                    {
                        MessageBox.Show("Нет такого количества предметов");
                    }
                }
                else
                {
                    MessageBox.Show("Введите корректное число");
                }
            }
        }
    }
}
