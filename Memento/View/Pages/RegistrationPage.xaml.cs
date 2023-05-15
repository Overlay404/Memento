using Memento.Model;
using Memento.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                try
                {
                    if (Login.TextInTextBox == null || Password.TextInTextBox == null)
                        throw new Exception();

                    Visitor visitor = new Visitor
                    {
                        Login = Login.TextInTextBox.Trim(),
                        Password = Password.TextInTextBox.Trim()
                    };

                    (List<string> message, bool flag) = ValidatePassword(Password.TextInTextBox.Trim());

                    if (flag == false)
                    {
                        MessageBox.Show(string.Join("\n", message), "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }

                    Connection.db.Visitor.Add(visitor);

                    Connection.db.SaveChanges();

                    Connection.User = visitor;
                    MainWindow.Instance.MainFrame.Navigate(new SelectionPage());
                }
                catch (Exception)
                {
                    MessageBox.Show("Проверьте все поля");
                }
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

        private (List<string>, bool) ValidatePassword(string password)
        {
            List<string> message = new List<string>();

            if (password.Length < 6)
                message.Add("Пароль должен быть не менее 6 символов");
            if (!password.Any(c => Char.IsUpper(c)))
                message.Add("В пароле должна быть хотя бы одна прописная буква");
            if (!Regex.IsMatch(password, @"\d"))
                message.Add("В пароле должна быть хотя бы одна цифра");
            if (!Regex.IsMatch(password, @"[!@#$%^]"))
                message.Add("В пароле должен быть хотя бы одний из символов ! @ # $ % ^");

            return message.Count == 0 ? (null, true) : (message, false);
        }
    }
}
