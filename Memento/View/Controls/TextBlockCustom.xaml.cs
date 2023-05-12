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

namespace Memento.View.Controls
{
    /// <summary>
    /// Логика взаимодействия для TextBloclCustom.xaml
    /// </summary>
    public partial class TextBlockCustom : UserControl
    {


        public string TextInTextBlock
        {
            get { return (string)GetValue(TextInTextBlockProperty); }
            set { SetValue(TextInTextBlockProperty, value); }
        }

        public static readonly DependencyProperty TextInTextBlockProperty =
            DependencyProperty.Register("TextInTextBlock", typeof(string), typeof(TextBlockCustom));


        public TextBlockCustom()
        {
            InitializeComponent();
        }
    }
}
