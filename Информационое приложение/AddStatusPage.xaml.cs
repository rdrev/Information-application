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
    /// Логика взаимодействия для AddStatusPage.xaml
    /// </summary>
    public partial class AddStatusPage : Page
    {
        private Статусы статус = null;

        public AddStatusPage(Статусы статус)
        {
            InitializeComponent();

            this.статус = статус;

            DataContext = this.статус;
        }

        private void OKBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (статус.КодСтатус == 0)
                {
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Статусы.Add(статус); 
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().SaveChanges();
                }
                else
                {
                    var статус = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Статусы.Find(this.статус.КодСтатус);
                    статус = this.статус;
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
