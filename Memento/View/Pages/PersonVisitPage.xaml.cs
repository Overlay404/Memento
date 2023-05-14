using Memento.Model;
using Memento.View.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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


        public PersonVisitPage()
        {
            PhotoPerson = (ImageSource)new BitmapImage(new Uri(@"..\..\Image\Person.png", UriKind.Relative));

            InitializeComponent();

            AttachFile.MouseDown += (sender, e) =>
            {
                AttachFile.Visibility = Visibility.Collapsed;
                NameFile = OpenFileDialogSave();
            };
            LoadImageBtn.Click += (sender, e) => { PhotoPerson = ConvertToImageSource(OpenImageDialogSave()); };
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
