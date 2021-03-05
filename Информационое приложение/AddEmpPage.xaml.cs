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
    /// Логика взаимодействия для AddEmpPage.xaml
    /// </summary>
    public partial class AddEmpPage : Page
    {
        private Сотрудники сотрудник = null;

        public AddEmpPage(Сотрудники сотрудник)
        {
            InitializeComponent();

            this.сотрудник = сотрудник;

            DataContext = this.сотрудник;

            CBO.ItemsSource = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Отрасли.ToList(); 
        }

        private void OKBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(сотрудник.КодСотрудников == 0)
                {
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Сотрудники.Add(сотрудник);
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().SaveChanges();
                }
                else
                {
                    var сотрудник = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Сотрудники.Find(this.сотрудник.КодСотрудников);
                    сотрудник = this.сотрудник;
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
