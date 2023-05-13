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
        }

        private void GoToPerson(object sender, MouseButtonEventArgs e) =>
            MainWindow.Instance.MainFrame.Navigate(new PersonVisitPage());

        private void GoToGroup(object sender, MouseButtonEventArgs e) =>
            MainWindow.Instance.MainFrame.Navigate(new GroupVisitPage());
    }
}
