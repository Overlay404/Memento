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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();

            InBtn.Click += (sender, e) =>
            {
                Connection.db.User.Add(new User
                {
                    Login = Login.TextInTextBox.Trim(),
                    Password = Password.TextInTextBox.Trim()
                });
                Connection.db.SaveChanges();

                MainWindow.Instance.MainFrame.Navigate(new SelectionPage());
            };
            RegBtn.Click += (sender, e) =>
            {
                MainWindow.Instance.MainFrame.Navigate(new AutorizationPage());
            };
            SabmitRequest.Click += (sender, e) =>
            {
                MainWindow.Instance.MainFrame.Navigate(new SelectionPage());
            };
        }
    }
}
