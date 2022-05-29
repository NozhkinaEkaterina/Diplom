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

namespace HumanResourcesDepartmentApp
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
        }
        private void BtnSchedule_Click(object sender, RoutedEventArgs e)//перейти(редактировать)
        {
            Manager.MainFrame.Navigate(new AddEditProfilePage((sender as Button).DataContext as Profile));//передаем контекст на страницу AddEditProfilePage
        }

        private void Add_Click(object sender, RoutedEventArgs e)//добавить новый профиль
        {
            Manager.MainFrame.Navigate(new AddEditProfilePage(null));//передаем нулевой контекст на страницу AddEditProfilePage
        }

        private void Search_Click(object sender, RoutedEventArgs e)//поиск
        {
            string search = TBSearch.Text;

            var profile = HumanResourcesDepartmentEntities.GetContext().Profile.ToList();
            DGProfile.ItemsSource = profile.Where(c => c.Full_Name.Contains(search));//из списка профилей ищем все, куда входит то, что ввели
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)//вывод данных по привязке
        {
            if (Visibility == Visibility.Visible)
            {
                HumanResourcesDepartmentEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGProfile.ItemsSource = HumanResourcesDepartmentEntities.GetContext().Profile.ToList();//отображаем всех из таблицы Profile
            }
        }
    }
}
