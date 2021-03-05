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
    /// Логика взаимодействия для AddBeneathTaskPage.xaml
    /// </summary>
    public partial class AddBeneathTaskPage : Page
    {
        private ПодЗадачи подЗадача = null;
        private Задания задания = null;

        public AddBeneathTaskPage(Задания задания, ПодЗадачи подЗадача)
        {
            InitializeComponent();

            this.подЗадача = подЗадача;
            this.задания = задания;

            DataContext = this.подЗадача;

            CBO.ItemsSource = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Статусы.ToList();
            CBE.ItemsSource = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Сотрудники.ToList();

            if(подЗадача.КодПодЗадачи != 0)
            {
                TBE.Visibility = Visibility.Hidden;
                CBE.Visibility = Visibility.Hidden;
            }    
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (подЗадача.КодПодЗадачи != 0)
                {
                    var подзадача = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().ПодЗадачи.Find(подЗадача.КодПодЗадачи);
                    подзадача = подЗадача;

                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().SaveChanges();
                }
                else
                {
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().ПодЗадачи.Add(подЗадача);
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().SaveChanges();

                    СписокИсполнителей списокИсполнителей = new СписокИсполнителей();

                    списокИсполнителей.ПодЗадачи = подЗадача;
                    списокИсполнителей.Задания = задания;
                    списокИсполнителей.Сотрудник = (CBE.SelectedItem as Сотрудники).КодСотрудников;

                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().СписокИсполнителей.Add(списокИсполнителей);
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().SaveChanges();

                    MenegerFrame.Frame.GoBack();

                }
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
