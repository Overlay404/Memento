using Memento.Model;
using Memento.View.Windows;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
    /// Логика взаимодействия для GroupVisitPage.xaml
    /// </summary>
    public partial class GroupVisitPage : Page
    {
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



        Regex emailRegex = new Regex(@"([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9_-]+)");
        Regex phoneRegex = new Regex(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$");

        public GroupVisitPage()
        {
            Divisions = Connection.db.Division.ToList();
            Employee = Connection.db.Employee.ToList();
            VisitPurposes = Connection.db.VisitPurpose.ToList();

            Visitors = new List<Visitor>();
            InitializeComponent();

            Series.KeyDown += (sender, e) => 
            {
                if (new KeyConverter().ConvertToString(e.Key).All(letter => char.IsLetter(letter)))
                    e.Handled = true;
            };
            Number.KeyDown += (sender, e) =>
            {
                if (new KeyConverter().ConvertToString(e.Key).All(letter => char.IsLetter(letter)))
                    e.Handled = true;
            };
            Phone.KeyDown += (sender, e) =>
            {
                if (new KeyConverter().ConvertToString(e.Key).All(letter => char.IsLetter(letter)))
                    e.Handled = true;
            };
            ClearForm.Click += (sender, e) =>
            {
                MainWindow.Instance.MainFrame.Navigate(new GroupVisitPage());
            };
            AttachFile.MouseDown += (sender, e) =>
            {
                AttachFile.Visibility = Visibility.Collapsed;
                NameFileTry = OpenFileDialogSave();
            };
            AddingVisitor.MouseDown += (sender, e) =>
            {
                try
                {
                    VisitPurpose cbVisit = VisitPurposeCB.SelectedItem as VisitPurpose;
                    Division cbDivision = DivisionCB.SelectedItem as Division;
                    Employee cbEmpl = EmployeeCB.SelectedItem as Employee;

                    VisitPurpose visitPurposeName = Connection.db.VisitPurpose.FirstOrDefault(v => v.Name == (cbVisit).Name);
                    int divisionId = Connection.db.Division.FirstOrDefault(d => d.Name == (cbDivision).Name).Id;
                    int employeeId = Connection.db.Employee.FirstOrDefault(em => em.LastName == (cbEmpl).LastName).Id;


                    Visitor visitor = new Visitor
                    {
                        LastName = SurnameInForm.TextInTextBox,
                        FirstName = NameInForm.TextInTextBox,
                        Patronymic = PatronymicnForm.TextInTextBox,
                        Email = Mail.TextInTextBox == null ? null : Mail.TextInTextBox.Trim(), 
                        Phone = Phone.TextInTextBox == null ? null : Phone.TextInTextBox.Trim(),
                        OrganizationId = 1,
                        Note = Note.TextInTextBox,
                        PassportSeries = Series.TextInTextBox,
                        PassportNumber = Number.TextInTextBox,
                        BirthDate = DateTime.Today,
                    };

                    Request request = new Request
                    {
                        RequestTypeId = 1,
                        RequestStatusId = 1,
                        DesiredStartDate = WithDatePicker.SelectedDate ?? DateTime.Today,
                        DesiredExpirationDate = ByDatePicker.SelectedDate ?? DateTime.Today,
                        VisitPurpose = visitPurposeName,
                        DivisionId = divisionId,
                        EmployeeId = employeeId
                    };

                    request.Visitor.Add(visitor);

                    Connection.db.Request.Add(request);

                    Connection.db.Visitor.Add(visitor);

                    Visitors.Add(visitor);
                    ListVisitor.ItemsSource = Visitors;
                    ListVisitor.Items.Refresh();

                    if (!Validate(emailRegex, phoneRegex))
                    {
                        MessageBox.Show("Не введены или не соответсвуют формату данные");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не введены или не соответсвуют формату данные");
                }
            };
            CreateRequestBtn.Click += (sender, e) =>
            {
                try
                {
                    Connection.db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    List<string> mess = new List<string>();

                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            mess.Add("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }

                    MessageBox.Show(string.Join("\n", mess));
                }

                MessageBox.Show($"Заявка на имя {SurnameInForm.TextInTextBox} {NameInForm.TextInTextBox} {PatronymicnForm.TextInTextBox} заполнена");
            };
        }

        private bool Validate(Regex emailRegex, Regex phoneRegex)
        {
            if(Mail.TextInTextBox != null || Phone.TextInTextBox != null)
            {
                if (phoneRegex.IsMatch(Phone.TextInTextBox) || emailRegex.IsMatch(Mail.TextInTextBox)) return false;
            }
            return true;
        }

        public static string OpenFileDialogSave()
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "All files| *.txt;*.docx;*.doc;*.pdf*.xls"
            };

            if (openFile.ShowDialog().GetValueOrDefault())
                return openFile.FileName;

            return null;
        }

        private void TheHostViewCustom_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            MainWindow.Instance.MainFrame.Navigate(new SelectionPage());
        }
    }
}
