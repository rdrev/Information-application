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
    /// Логика взаимодействия для BeneathTaskPage.xaml
    /// </summary>
    public partial class BeneathTaskPage : Page
    {
        private СписокИсполнителей[] списокИсполнителей = null;
        private Задания задания = null;

        public BeneathTaskPage(Задания задания)
        {
            InitializeComponent();

            this.задания = задания;

           
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.GoBack();
        }

        private void AddBeneathTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new AddBeneathTaskPage(задания, new ПодЗадачи()));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            updata();
        }

        private void EmpBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new EmpPage(списокИсполнителей, (sender as Button).DataContext as ПодЗадачи));
        }

        private void UpTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new AddBeneathTaskPage(задания, (sender as Button).DataContext as ПодЗадачи));
        }

        private void DelTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool prov = false;
                var подЗадача = (sender as Button).DataContext as ПодЗадачи;
                var задача = списокИсполнителей[0].Задания;

                if (списокИсполнителей.Count() == 1)
                    prov = true;

                for (int i = 0; i < списокИсполнителей.Count(); i++)
                {
                    if(списокИсполнителей[i].ПодЗадача == подЗадача.КодПодЗадачи)
                        ИнформационаяБазаEntities.GetИнформационаяБазаEntities().СписокИсполнителей.Remove(списокИсполнителей[i]);
                }


                ИнформационаяБазаEntities.GetИнформационаяБазаEntities().ПодЗадачи.Remove(подЗадача);


                if (prov)
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Задания.Remove(задача);


                ИнформационаяБазаEntities.GetИнформационаяБазаEntities().SaveChanges();

                updata();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updata()
        {
            var b = задания.СписокИсполнителей;

            списокИсполнителей = new СписокИсполнителей[b.Count];

            b.CopyTo(списокИсполнителей, 0);

            List<ПодЗадачи> список = new List<ПодЗадачи>();

            for (int i = 0; i < списокИсполнителей.Count(); i++)
            {
                var подзадача = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().ПодЗадачи.ToList().Find(p => p.КодПодЗадачи == списокИсполнителей[i].ПодЗадача);
                список.Add(подзадача);
            }

            список = список.Distinct().ToList();

            DG.ItemsSource = список;
        }
    }
}
