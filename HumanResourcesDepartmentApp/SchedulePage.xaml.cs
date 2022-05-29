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
    /// Логика взаимодействия для SchedulePage.xaml
    /// </summary>
    public partial class SchedulePage : Page
    {
        public SchedulePage()
        {
            InitializeComponent();
            CBSearch.ItemsSource = HumanResourcesDepartmentEntities.GetContext().Profile.ToList();
        }

        private void BtnSchedule_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditSchedulePage((sender as Button).DataContext as Schedule));
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditSchedulePage(null));
        }

        private void Search_Click(object sender, RoutedEventArgs e)//кнопка сформировать
        {
            if (CBSearch.Text != "")//проверка на выбран ли специалист
            {
                int search = Convert.ToInt32(CBSearch.SelectedValue);//выбор в комбобоксе какого-то человека
                if (Visibility == Visibility.Visible)
                {
                    HumanResourcesDepartmentEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    DGSchedule.ItemsSource = HumanResourcesDepartmentEntities.GetContext().Schedule.Where(u => u.Id_Profile == search).ToList();//выводим информацию по выбранному человеку
                }
            }
            else MessageBox.Show("Выберите специалиста!");
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            var ScheduleForRemoving = DGSchedule.SelectedItems.Cast<Schedule>().ToList();//считываем те элементы в расписании, котрые выбрали

            if (MessageBox.Show($"Вы точно хотите удалить следующие {ScheduleForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)//выводим сообщение-предупреждение: хотите ли удалить
            {//если да
                try
                {
                    HumanResourcesDepartmentEntities.GetContext().Schedule.RemoveRange(ScheduleForRemoving);//удаляем из контекста выбранное
                    HumanResourcesDepartmentEntities.GetContext().SaveChanges();//сохраняем изменения в контексте
                    MessageBox.Show("Данные удалены!");

                    DGSchedule.ItemsSource = HumanResourcesDepartmentEntities.GetContext().Schedule.ToList();//выводим в список все расписание без удаленных
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
