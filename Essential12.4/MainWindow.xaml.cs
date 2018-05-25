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

namespace Essential12._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        #region События нажания кнопок
        public event Action ButtonPlusClick;
        public event Action ButtonMinusClick;
        public event Action ButtonMultiplyClick;
        public event Action ButtonDivideClick;
        public event Action ButtonDigit0Click;
        public event Action ButtonDigit1Click;
        public event Action ButtonDigit2Click;
        public event Action ButtonDigit3Click;
        public event Action ButtonDigit4Click;
        public event Action ButtonDigit5Click;
        public event Action ButtonDigit6Click;
        public event Action ButtonDigit7Click;
        public event Action ButtonDigit8Click;
        public event Action ButtonDigit9Click;
        public event Action ButtonPointClick;
        public event Action ButtonEqualsClick;
        public event Action ButtonClearClick;
        #endregion

        #region Методы нажатия кнопок
        private void ButtonDidigt1_Click(object sender, RoutedEventArgs e)
        {
            ButtonDigit1Click.Invoke();
        }

        private void ButtonDidigt2_Click(object sender, RoutedEventArgs e)
        {
            ButtonDigit2Click.Invoke();
        }

        private void ButtonDidigt3_Click(object sender, RoutedEventArgs e)
        {
            ButtonDigit3Click.Invoke();
        }

        private void ButtonDidigt4_Click(object sender, RoutedEventArgs e)
        {
            ButtonDigit4Click.Invoke();
        }

        private void ButtonDidigt5_Click(object sender, RoutedEventArgs e)
        {
            ButtonDigit5Click.Invoke();
        }

        private void ButtonDidigt6_Click(object sender, RoutedEventArgs e)
        {
            ButtonDigit6Click.Invoke();
        }

        private void ButtonDidigt7_Click(object sender, RoutedEventArgs e)
        {
            ButtonDigit7Click.Invoke();
        }

        private void ButtonDidigt8_Click(object sender, RoutedEventArgs e)
        {
            ButtonDigit8Click.Invoke();
        }

        private void ButtonDidigt9_Click(object sender, RoutedEventArgs e)
        {
            ButtonDigit9Click.Invoke();
        }

        private void ButtonDidigt0_Click(object sender, RoutedEventArgs e)
        {
            ButtonDigit0Click.Invoke();
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            ButtonPlusClick.Invoke();
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            ButtonMinusClick.Invoke();
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            ButtonMultiplyClick.Invoke();
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            ButtonDivideClick.Invoke();
        }

        private void ButtonPoint_Click(object sender, RoutedEventArgs e)
        {
            ButtonPointClick.Invoke();
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            ButtonEqualsClick.Invoke();
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            ButtonClearClick.Invoke();
        }
        #endregion
    }
}
