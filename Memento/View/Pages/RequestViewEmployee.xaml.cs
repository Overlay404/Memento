using Memento.Model;
using Memento.View.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Memento.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RequestViewEmployee.xaml
    /// </summary>
    public partial class RequestViewEmployee : Page
    {
        public IEnumerable<(Visitor, Request)> RequestList
        {
            get { return (IEnumerable<(Visitor, Request)>)GetValue(RequestListProperty); }
            set { SetValue(RequestListProperty, value); }
        }

        public static readonly DependencyProperty RequestListProperty =
            DependencyProperty.Register("RequestList", typeof(IEnumerable<(Visitor, Request)>), typeof(RequestViewEmployee));


        public RequestViewEmployee()
        {
            foreach (var visitor in Connection.db.Visitor.Local)
                foreach (var request in visitor.Request)
                    RequestList.Append((visitor, request));

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (RequestTable.SelectedItems == null)
                return;

            foreach (Request request in RequestTable.SelectedItems)
                Connection.db.Request.Local.FirstOrDefault(x => x.Id == request.Id).RequestStatusId = 2;

            Connection.db.SaveChanges();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (RequestTable.SelectedItems == null)
                return;

            foreach (Request request in RequestTable.SelectedItems)
                Connection.db.Request.Local.FirstOrDefault(x => x.Id == request.Id).RequestStatusId = 3;

            Connection.db.SaveChanges();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.MainFrame.Navigate(new AutorizationPage());
            Connection.UserEmployee = null;
        }
    }
}
