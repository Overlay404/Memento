using System.Windows;
using System.Windows.Controls;

namespace Memento.View.Controls
{
    /// <summary>
    /// Логика взаимодействия для TextBoxCustom.xaml
    /// </summary>
    public partial class TextBoxCustomForPhone : UserControl
    {
        public string TextInTextBoxForPhone
        {
            get { return (string)GetValue(TextBoxCustomForPhoneProperty); }
            set { SetValue(TextBoxCustomForPhoneProperty, value); }
        }

        public static readonly DependencyProperty TextBoxCustomForPhoneProperty =
            DependencyProperty.Register("TextInTextBoxForPhone", typeof(string), typeof(TextBoxCustomForPhone));



        public TextBoxCustomForPhone()
        {
            InitializeComponent();
        }
    }
}
