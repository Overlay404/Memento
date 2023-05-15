using Memento.Model;
using Memento.View.Windows;
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

namespace Memento.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();

            InBtn.Click += (sender, e) =>
            {
                if(Connection.db.User.FirstOrDefault(v => v.Login == Login.TextInTextBox.Trim() && v.Password == Password.TextInTextBox.Trim()) != null)
                {
                    MainWindow.Instance.MainFrame.Navigate(new SelectionPage());
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует");
                }
            };
            RegBtn.Click += (sender, e) =>
            {
                MainWindow.Instance.MainFrame.Navigate(new RegistrationPage());
            };
        }
    }
}
