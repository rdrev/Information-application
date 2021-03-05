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
    /// Логика взаимодействия для AddBranchPage.xaml
    /// </summary>
    public partial class AddBranchPage : Page
    {
        private Отрасли отрасл = null;

        public AddBranchPage(Отрасли отрасл)
        {
            InitializeComponent();

            this.отрасл = отрасл;

            DataContext = this.отрасл;
        }

        private void OKBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (отрасл.КодОтрасли == 0)
                {
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Отрасли.Add(отрасл);
                    ИнформационаяБазаEntities.GetИнформационаяБазаEntities().SaveChanges();
                }
                else
                {
                    var отрасл  = ИнформационаяБазаEntities.GetИнформационаяБазаEntities().Отрасли.Find(this.отрасл.КодОтрасли);
                    отрасл = this.отрасл;
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
