using Memento.Model;
using Memento.View.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Memento.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для SelectionPage.xaml
    /// </summary>
    public partial class SelectionPage : Page
    {
        public SelectionPage()
        {
            InitializeComponent();

            if (Connection.User == null)
                EnterLogin.Content = "Войти в аккаунт";
            else
                EnterLogin.Content = "Выйти из аккаунта";

            EnterLogin.Click += (sender, e) =>
            {
                Connection.User = null;    
                MainWindow.Instance.MainFrame.Navigate(new AutorizationPage());
            };

            ViewRequests.Click += (sender, e) =>
            {
                MainWindow.Instance.MainFrame.Navigate(new RequestViewEmployee(Connection.User));
            };
        }

        private void GoToPerson(object sender, MouseButtonEventArgs e) =>
            MainWindow.Instance.MainFrame.Navigate(new PersonVisitPage());

        private void GoToGroup(object sender, MouseButtonEventArgs e) =>
            MainWindow.Instance.MainFrame.Navigate(new GroupVisitPage());
    }
}
