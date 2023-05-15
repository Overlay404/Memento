using Memento.Model;
using Memento.View.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Validation;
using System.IO;
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
    /// Логика взаимодействия для PersonVisitPage.xaml
    /// </summary>
    public partial class PersonVisitPage : Page
    {
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

        Regex emailRegex = new Regex(@"([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9_-]+)");
        Regex phoneRegex = new Regex(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$");

        public PersonVisitPage()
        {
            PhotoPerson = (ImageSource)new BitmapImage(new Uri(@"..\..\Image\Person.png", UriKind.Relative));

            Divisions = Connection.db.Division.ToList();
            Employee = Connection.db.Employee.ToList();
            VisitPurposes = Connection.db.VisitPurpose.ToList();

            InitializeComponent();
            

            AttachFile.MouseDown += (sender, e) =>
            {
                AttachFile.Visibility = Visibility.Collapsed;
                NameFile = OpenFileDialogSave();
            };
            LoadImageBtn.Click += (sender, e) => { PhotoPerson = ConvertToImageSource(OpenImageDialogSave()); };

            CreateRequestBtn.Click += (sender, e) =>
            {
                if (Connection.User == null)
                    NewVisitorIfUserNull();
                else
                    NewVisitorIfUserNotNull();

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

                MessageBox.Show($"Заявка на имя {Surname.TextInTextBox} {Name.TextInTextBox} {Patronymic.TextInTextBox} заполнена");
            };
        }

        private void NewVisitorIfUserNull()
        {
            
                VisitPurpose cbVisit = VisitPurposeCB.SelectedItem as VisitPurpose;
                Division cbDivision = DivisionCB.SelectedItem as Division;
                Employee cbEmpl = EmployeeCB.SelectedItem as Employee;

                if (Validate(emailRegex, phoneRegex, cbVisit, cbDivision, cbEmpl))
                {
                    MessageBox.Show("Не введены или не соответсвуют формату данные");
                }

                VisitPurpose visitPurposeName = Connection.db.VisitPurpose.FirstOrDefault(v => v.Name == (cbVisit).Name);
                int divisionId = Connection.db.Division.FirstOrDefault(d => d.Name == (cbDivision).Name).Id;
                int employeeId = Connection.db.Employee.FirstOrDefault(em => em.LastName == (cbEmpl).LastName).Id;

            Visitor visitor = new Visitor
            {
                LastName = Surname.TextInTextBox.Trim(),
                FirstName = Name.TextInTextBox.Trim(),
                Patronymic = Patronymic.TextInTextBox.Trim(),
                BirthDate = DateTime.Today
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

            visitor.Request.Add(request);

            Connection.db.Request.Add(request);

            Connection.db.Visitor.Add(visitor);
        }

        private void NewVisitorIfUserNotNull()
        {

            VisitPurpose cbVisit = VisitPurposeCB.SelectedItem as VisitPurpose;
            Division cbDivision = DivisionCB.SelectedItem as Division;
            Employee cbEmpl = EmployeeCB.SelectedItem as Employee;

            if (Validate(emailRegex, phoneRegex, cbVisit, cbDivision, cbEmpl))
            {
                MessageBox.Show("Не введены или не соответсвуют формату данные");
            }

            VisitPurpose visitPurposeName = Connection.db.VisitPurpose.FirstOrDefault(v => v.Name == (cbVisit).Name);
            int divisionId = Connection.db.Division.FirstOrDefault(d => d.Name == (cbDivision).Name).Id;
            int employeeId = Connection.db.Employee.FirstOrDefault(em => em.LastName == (cbEmpl).LastName).Id;


            Connection.User.LastName = Surname.TextInTextBox.Trim();
            Connection.User.FirstName = Name.TextInTextBox.Trim();
            Connection.User.Patronymic = Patronymic.TextInTextBox.Trim();
            Connection.User.BirthDate = DateTime.Today;
            

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

            Connection.User.Request.Add(request);

            Connection.db.Request.Add(request);
        }

        private bool Validate(Regex emailRegex, Regex phoneRegex, VisitPurpose cbVisit, Division cbDivision, Employee cbEmpl)
        {
            if (cbVisit == null || cbDivision == null || cbEmpl == null || DataPickerBithday.SelectedDate == null) return false;
            if (string.IsNullOrEmpty(Surname.TextInTextBox) || string.IsNullOrEmpty(Name.TextInTextBox) || string.IsNullOrEmpty(Patronymic.TextInTextBox)) return false;
            if (emailRegex.IsMatch(Mail.TextInTextBox.Trim()) || phoneRegex.IsMatch(Phone.TextInTextBox.Trim())) return false;
            return true;
        }

        public static byte[] OpenImageDialogSave()
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Image files|*.jpg;*.jpeg;*.png"
            };

            if (openFile.ShowDialog().GetValueOrDefault())
            {
                BitmapFrame.Create(new MemoryStream(File.ReadAllBytes(openFile.FileName)), BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                return File.ReadAllBytes(openFile.FileName);
            }
            return null;
        }

        public static ImageSource ConvertToImageSource(byte[] bytes)
        {
            if (bytes == null) return null;

            BitmapImage biImg = new BitmapImage();
            MemoryStream ms = new MemoryStream(bytes);
            biImg.BeginInit();
            biImg.StreamSource = ms;
            biImg.EndInit();
            ImageSource image = biImg as ImageSource;
            return image;
        }

        public static string OpenFileDialogSave()
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "All files| *.txt;*.docx;*.doc;*.pdf*.xls"
            };

            if (openFile.ShowDialog().GetValueOrDefault())
            {
                return openFile.FileName;
            }
            return null;
        }
    }
}
