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
    /// Логика взаимодействия для AddTaskPage.xaml
    /// </summary>
    public partial class AddTaskPage : Page
    {
        private Задания задания = null;

        public AddTaskPage(Задания задания, Клиенты клиент)
        {
            InitializeComponent();

            this.задания = задания;

            DataContext = this.задания;

            CBO.ItemsSource = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Отрасли.ToList();

            if (this.задания.КодЗадание == 0)
            {
                this.задания.СтатусЗадание = 2;
                this.задания.Начало = DateTime.Today;
                this.задания.Оканчание = DateTime.Today;
            }

            if (клиент != null)
            {
                CBK.Visibility = Visibility.Hidden;
                TBK.Visibility = Visibility.Hidden;

                CBS.Visibility = Visibility.Hidden;
                TBS.Visibility = Visibility.Hidden;

                this.задания.Клиенты = клиент;
            }
            else
            {
                CBK.ItemsSource = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Клиенты.ToList();
                CBS.ItemsSource = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Статусы.ToList();
            }
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (задания.КодЗадание != 0)
                {
                    var исходЗадание = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Задания.Find(задания.КодЗадание);
                    исходЗадание = задания;
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().SaveChanges();
                }
                else
                {
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Задания.Add(задания);
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().SaveChanges();


                    СписокИсполнителей списокИсполнителей = new СписокИсполнителей();

                    List<Сотрудники> сотрудники = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Сотрудники.ToList().Where(p => p.Отрасаль == задания.Отрасаль).ToList();

                    Random rnd = new Random();

                    Сотрудники сотрудник = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Сотрудники.Find(сотрудники[rnd.Next(0, сотрудники.Count - 1)].КодСотрудников);
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().SaveChanges();

                    списокИсполнителей.Сотрудники = сотрудник;

                    ПодЗадачи подЗадача = new ПодЗадачи
                    {
                        Название = "Пусто",
                        СтатусПодЗадание = 2
                    };
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().ПодЗадачи.Add(подЗадача);
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().SaveChanges();

                    списокИсполнителей.ПодЗадачи = подЗадача;

                    списокИсполнителей.Задания = задания;

                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().СписокИсполнителей.Add(списокИсполнителей);
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().SaveChanges();

                }

                MenegerFrame.Frame.GoBack();
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
