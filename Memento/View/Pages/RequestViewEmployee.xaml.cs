using Memento.Model;
using Memento.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace Memento.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RequestViewEmployee.xaml
    /// </summary>
    public partial class RequestViewEmployee : Page
    {
        public List<VisitorRequest> RequestList
        {
            get { return (List<VisitorRequest>)GetValue(RequestListProperty); }
            set { SetValue(RequestListProperty, value); }
        }

        public static readonly DependencyProperty RequestListProperty =
            DependencyProperty.Register("RequestList", typeof(List<VisitorRequest>), typeof(RequestViewEmployee));


        public RequestViewEmployee(Visitor user = null)
        {
            RequestList = new List<VisitorRequest>();


            InitializeComponent();

            VilidatyUserForVisibilityNavigation(user);
        }
        private void VilidatyUserForVisibilityNavigation(Visitor user)
        {
            if (user == null)
            {
                NavigationForEmployee.Visibility = Visibility.Visible;
                NavigationViewRequstListForEmployee();
            }
            else
            {
                NavigationForEmployee.Visibility = Visibility.Collapsed;
                NavigationViewRequstListForVisitor(user);
            }
        }

        private void NavigationViewRequstListForEmployee()
        {
            foreach (var visitor in Connection.db.Visitor.Local)
                foreach (var request in visitor.Request)
                    RequestList.Add(new VisitorRequest
                        (
                            lastName: visitor.LastName,
                            firstName: visitor.FirstName,
                            patronymic: visitor.Patronymic,
                            id: request.Id,
                            requestTypeName: request.RequestType.Name,
                            requestStatusName: request.RequestStatus.Name,
                            desiredStartDate: request.DesiredStartDate,
                            desiredExpirationDate: request.DesiredExpirationDate,
                            visitPurposeName: request.VisitPurpose.Name
                        ));
        }

        private void NavigationViewRequstListForVisitor(Visitor visitor)
        {
            foreach (var request in visitor.Request)
                RequestList.Add(new VisitorRequest
                    (
                        lastName: visitor.LastName,
                        firstName: visitor.FirstName,
                        patronymic: visitor.Patronymic,
                        id: request.Id,
                        requestTypeName: request.RequestType.Name,
                        requestStatusName: request.RequestStatus.Name,
                        desiredStartDate: request.DesiredStartDate,
                        desiredExpirationDate: request.DesiredExpirationDate,
                        visitPurposeName: request.VisitPurpose.Name
                    ));
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (RequestTable.SelectedItems == null)
                return;

            foreach (VisitorRequest visitorRequest in RequestTable.SelectedItems)
            {
                Connection.db.Request.Local.FirstOrDefault(x => x.Id == visitorRequest.Id).RequestStatusId = 2;

                RequestList.First(x => x.Id == visitorRequest.Id).RequestStatusName = Connection.db.RequestStatus.Local.First(x => x.Id == 2).Name;
            }

            RequestTable.Items.Refresh();

            Connection.db.SaveChanges();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (RequestTable.SelectedItems == null)
                return;

            foreach (VisitorRequest visitorRequest in RequestTable.SelectedItems)
            {
                Connection.db.Request.Local.FirstOrDefault(x => x.Id == visitorRequest.Id).RequestStatusId = 3;
                RequestList.First(x => x.Id == visitorRequest.Id).RequestStatusName = Connection.db.RequestStatus.Local.First(x => x.Id == 3).Name;
            }

            RequestTable.Items.Refresh();

            Connection.db.SaveChanges();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.MainFrame.Navigate(new AutorizationPage());
            Connection.UserEmployee = null;
        }
    }
}
