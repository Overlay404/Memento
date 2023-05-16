using Memento.Model;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Memento.View.Pages
{
    partial class PersonVisitPage
    {
        #region Dependency Property
        public string NameFile
        {
            get { return (string)GetValue(NameFileProperty); }
            set { SetValue(NameFileProperty, value); }
        }

        public static readonly DependencyProperty NameFileProperty =
            DependencyProperty.Register("NameFile", typeof(string), typeof(PersonVisitPage));

        public ImageSource PhotoPerson
        {
            get { return (ImageSource)GetValue(PhotoPersonProperty); }
            set { SetValue(PhotoPersonProperty, value); }
        }

        public static readonly DependencyProperty PhotoPersonProperty =
            DependencyProperty.Register("PhotoPerson", typeof(ImageSource), typeof(PersonVisitPage));

        public IEnumerable<Division> Divisions
        {
            get { return (IEnumerable<Division>)GetValue(DivisionsProperty); }
            set { SetValue(DivisionsProperty, value); }
        }

        public static readonly DependencyProperty DivisionsProperty =
            DependencyProperty.Register("Divisions", typeof(IEnumerable<Division>), typeof(PersonVisitPage));


        public IEnumerable<VisitPurpose> VisitPurposes
        {
            get { return (IEnumerable<VisitPurpose>)GetValue(VisitPurposesProperty); }
            set { SetValue(VisitPurposesProperty, value); }
        }

        public static readonly DependencyProperty VisitPurposesProperty =
            DependencyProperty.Register("VisitPurposes", typeof(IEnumerable<VisitPurpose>), typeof(PersonVisitPage));

        public IEnumerable<Employee> Employee
        {
            get { return (IEnumerable<Employee>)GetValue(EmployeeProperty); }
            set { SetValue(EmployeeProperty, value); }
        }

        public static readonly DependencyProperty EmployeeProperty =
            DependencyProperty.Register("Employee", typeof(IEnumerable<Employee>), typeof(PersonVisitPage));

        public IEnumerable<Organization> Organizations
        {
            get { return (IEnumerable<Organization>)GetValue(OrganizationsProperty); }
            set { SetValue(OrganizationsProperty, value); }
        }

        public static readonly DependencyProperty OrganizationsProperty =
            DependencyProperty.Register("Organizations", typeof(IEnumerable<Organization>), typeof(PersonVisitPage));

        #endregion
    }
}
