using System.Windows;
using System.Windows.Controls;

namespace Memento.View.Controls
{
    /// <summary>
    /// Логика взаимодействия для TextBoxCustom.xaml
    /// </summary>
    public partial class TextBoxCustomForNumber : UserControl
    {
        public string TextInTextBox
        {
            get { return (string)GetValue(TextInTextBoxProperty); }
            set { SetValue(TextInTextBoxProperty, value); }
        }

        public static readonly DependencyProperty TextInTextBoxProperty =
            DependencyProperty.Register("TextInTextBox", typeof(string), typeof(TextBoxCustomForNumber));



        public TextBoxCustomForNumber()
        {
            InitializeComponent();
        }
    }
}
