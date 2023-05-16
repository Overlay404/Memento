using Memento.Model;
using System.Collections.Generic;
using System.Windows;

namespace Memento.View.Pages
{
    partial class GroupVisitPage
    {
        #region Dependency Property
        public IEnumerable<Organization> Organizations
        {
            get { return (IEnumerable<Organization>)GetValue(OrganizationsProperty); }
            set { SetValue(OrganizationsProperty, value); }
        }

        public static readonly DependencyProperty OrganizationsProperty =
            DependencyProperty.Register("Organizations", typeof(IEnumerable<Organization>), typeof(GroupVisitPage));

        public string NameFileTry
        {
            get { return (string)GetValue(NameFileProperty); }
            set { SetValue(NameFileProperty, value); }
        }

        public static readonly DependencyProperty NameFileProperty =
            DependencyProperty.Register("NameFileTry", typeof(string), typeof(GroupVisitPage));

        public List<Visitor> Visitors
        {
            get { return (List<Visitor>)GetValue(VisitorsProperty); }
            set { SetValue(VisitorsProperty, value); }
        }

        public static readonly DependencyProperty VisitorsProperty =
            DependencyProperty.Register("Visitors", typeof(List<Visitor>), typeof(GroupVisitPage));

        public IEnumerable<Division> Divisions
        {
            get { return (IEnumerable<Division>)GetValue(DivisionsProperty); }
            set { SetValue(DivisionsProperty, value); }
        }

        public static readonly DependencyProperty DivisionsProperty =
            DependencyProperty.Register("Divisions", typeof(IEnumerable<Division>), typeof(GroupVisitPage));

        public IEnumerable<VisitPurpose> VisitPurposes
        {
            get { return (IEnumerable<VisitPurpose>)GetValue(VisitPurposesProperty); }
            set { SetValue(VisitPurposesProperty, value); }
        }

        public static readonly DependencyProperty VisitPurposesProperty =
            DependencyProperty.Register("VisitPurposes", typeof(IEnumerable<VisitPurpose>), typeof(GroupVisitPage));

        public IEnumerable<Employee> Employee
        {
            get { return (IEnumerable<Employee>)GetValue(EmployeeProperty); }
            set { SetValue(EmployeeProperty, value); }
        }

        public static readonly DependencyProperty EmployeeProperty =
            DependencyProperty.Register("Employee", typeof(IEnumerable<Employee>), typeof(GroupVisitPage));

        #endregion
    }
}
