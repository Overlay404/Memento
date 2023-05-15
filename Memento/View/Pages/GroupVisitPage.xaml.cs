using Microsoft.Win32;
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
            DependencyProperty.Register("NameFileTry", typeof(string), typeof(PersonVisitPage));

        public GroupVisitPage()
        {
            InitializeComponent();

            AttachFile.MouseDown += (sender, e) =>
            {
                AttachFile.Visibility = Visibility.Collapsed;
                NameFileTry = OpenFileDialogSave();
            };
            CreateRequestBtn.Click += (sender, e) =>
            {

            };
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
    }
}
