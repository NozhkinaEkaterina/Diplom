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

namespace HumanResourcesDepartmentApp
{
    /// <summary>
    /// Логика взаимодействия для ControlWindow.xaml
    /// </summary>
    public partial class ControlWindow : Window
    {
        public ControlWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new ControlPage());//подгрузка страницы ControlPage в окно при открытии
            Manager.MainFrame = MainFrame;
        }

        private void Back_Click(object sender, RoutedEventArgs e)//кнопка назад
        {
            Manager.MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)//проверка на то, может ли сделать "назад"
        {
            if (MainFrame.CanGoBack)
            {
                Back.Visibility = Visibility.Visible;//кнопка назад видна
            }
            else
            {
                Back.Visibility = Visibility.Hidden;//кнопка назад пропадает
            }
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}