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
    /// Логика взаимодействия для BranchLookPage.xaml
    /// </summary>
    public partial class BranchLookPage : Page
    {
        public BranchLookPage()
        {
            InitializeComponent();
        }

        private void ClerBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.GoBack();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new AddBranchPage(new Отрасли()));
        }

        private void UpBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new AddBranchPage((sender as Button).DataContext as Отрасли));
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы дельствительно хотете удалить пазицию", "Подверждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Отрасли.Remove((sender as Button).DataContext as Отрасли);
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().SaveChanges();
                    DG.ItemsSource = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Отрасли.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            DG.ItemsSource = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Отрасли.ToList();
        }
    }
}
