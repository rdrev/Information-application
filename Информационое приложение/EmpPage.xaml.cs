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
    /// Логика взаимодействия для EmpPage.xaml
    /// </summary>
    public partial class EmpPage : Page
    {
        private СписокИсполнителей[] списокИсполнителей = null;

        private ПодЗадачи подЗадачи = null;

        private Задания задания = null;

        public EmpPage(Задания задания)
        {
            InitializeComponent();

            this.задания = задания;

            CBE.ItemsSource = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Сотрудники.ToList();

            CBE.Visibility = Visibility.Hidden;
            AddTaskEmpBtn.Visibility = Visibility.Hidden;

        }

        public EmpPage(СписокИсполнителей[] списокИсполнителей, ПодЗадачи подЗадачи)
        {
            InitializeComponent();

            this.списокИсполнителей = списокИсполнителей;

            CBE.ItemsSource = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Сотрудники.ToList();

            this.подЗадачи = подЗадачи;

            this.задания = списокИсполнителей[0].Задания;
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.GoBack();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var b = задания.СписокИсполнителей;

            списокИсполнителей = new СписокИсполнителей[b.Count];

            b.CopyTo(списокИсполнителей, 0);

            List<Сотрудники> список = new List<Сотрудники>();

            for (int i = 0; i < списокИсполнителей.Count(); i++)
            {
                Сотрудники сотрудник;
                if (подЗадачи == null)
                    сотрудник = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Сотрудники.ToList().Find(p => p.КодСотрудников == списокИсполнителей[i].Сотрудник);
                else if (списокИсполнителей[i].ПодЗадача == подЗадачи.КодПодЗадачи)
                    сотрудник = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Сотрудники.ToList().Find(p => p.КодСотрудников == списокИсполнителей[i].Сотрудник && списокИсполнителей[i].ПодЗадача == подЗадачи.КодПодЗадачи);
                else
                    continue;

                список.Add(сотрудник);
            }


            список = список.Distinct().ToList();

            DG.ItemsSource = список;
        }

        private void AddTaskEmpBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CBE.SelectedIndex != -1)
                {
                    СписокИсполнителей _списокИсполнителей = new СписокИсполнителей();

                    _списокИсполнителей = списокИсполнителей[0];


                    _списокИсполнителей.Сотрудник = (CBE.SelectedItem as Сотрудники).КодСотрудников;

                    var emp = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Сотрудники.Find(_списокИсполнителей.Сотрудник);

                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().СписокИсполнителей.Add(_списокИсполнителей);
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().SaveChanges();

                    MenegerFrame.Frame.GoBack();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
