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

namespace Информационое_приложение
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private Сотрудники сотрудник = null;

        public MainPage(Сотрудники сотрудник)
        {
            InitializeComponent();

            this.сотрудник = сотрудник;
        }

        private void AddTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new AddTaskPage(new Задания(), null));
        }

        private void PodTaskUpdBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new BeneathTaskPage((sender as Button).DataContext as Задания));
        }

        private void AddStatusBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new StatusLookPage());
        }

        private void AddEmployeesBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new EmpLookPage());
        }

        private void AddBranchBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new BranchLookPage());
        }

        private void UpTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new AddTaskPage((sender as Button).DataContext as Задания, null));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            DG.ItemsSource = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Задания.ToList();
        }

        private void EmpBtn_Click(object sender, RoutedEventArgs e)
        {
           MenegerFrame.Frame.Navigate(new EmpPage((sender as Button).DataContext as Задания));
        }

       
    }
}
