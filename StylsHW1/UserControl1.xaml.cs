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

namespace StylsHW1
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private int count;
        private string Name { get; set; }
        public event Action SomethingChanged;
        public int Count
        {
            get => сount;
            set
            {
                count = value;
                countTextBlock.Text = count.ToString();
                SomethingChanged?.Invoke();
            }
        }
        public UserControl1(Action action)
        {
            InitializeComponent();
            Count = 0;
            SomethingChanged += action;
            this.Name = nameTextBox.Text;
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            Count++;
        }
    }
}
