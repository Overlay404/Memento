using Memento.Model;
using Memento.View.Windows;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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
                if(Connection.db.Visitor.FirstOrDefault(v => v.Login == Login.TextInTextBox.Trim() && v.Password == Password.TextInTextBox.Trim()) != null)
                {
                    Connection.User = Connection.db.Visitor.FirstOrDefault(v => v.Login == Login.TextInTextBox.Trim() && v.Password == Password.TextInTextBox.Trim());
                    MainWindow.Instance.MainFrame.Navigate(new SelectionPage());
                }
                else if (Connection.db.User.FirstOrDefault(v => v.Login == Login.TextInTextBox.Trim() && v.Password == Password.TextInTextBox.Trim()) != null)
                {
                    Connection.UserEmployee = Connection.db.User.FirstOrDefault(v => v.Login == Login.TextInTextBox.Trim() && v.Password == Password.TextInTextBox.Trim());
                    MainWindow.Instance.MainFrame.Navigate(new RequestViewEmployee());
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
