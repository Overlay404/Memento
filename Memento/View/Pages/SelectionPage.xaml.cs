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
                ViewRequests.Visibility = System.Windows.Visibility.Collapsed;
            else
                ViewRequests.Visibility = System.Windows.Visibility.Visible;

            EnterLogin.Click += (sender, e) =>
            {
                MainWindow.Instance.MainFrame.Navigate(new AutorizationPage());
            };

            ViewRequests.Click += (sender, e) =>
            {
                MainWindow.Instance.MainFrame.Navigate(new RequestViewEmployee());
            };
        }

        private void GoToPerson(object sender, MouseButtonEventArgs e) =>
            MainWindow.Instance.MainFrame.Navigate(new PersonVisitPage());

        private void GoToGroup(object sender, MouseButtonEventArgs e) =>
            MainWindow.Instance.MainFrame.Navigate(new GroupVisitPage());
    }
}
