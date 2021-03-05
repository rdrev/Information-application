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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        private Клиенты клиенты = new Клиенты();

        public RegistrationPage()
        {
            InitializeComponent();

            DataContext = клиенты;
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                клиенты.Пароль = password.Password.ToString();
                ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Клиенты.Add(клиенты);
                ИнформационаяБазаEntities.GetИнформационаяБазаEntities().SaveChanges();
                MenegerFrame.Frame.Navigate(new AddTaskPage(new Задания(), клиенты));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClerBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.GoBack();
        }
    }
}
