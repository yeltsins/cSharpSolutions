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

namespace Essential12._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            Presenter presenter  = new Presenter(this);
        }



        public event Action StartButtonAction;
        public event Action StopButtonAction;
        public event Action ClearButtonAction;

        private void StartS_Click(object sender, RoutedEventArgs e)
        {
            StartButtonAction.Invoke();
            
        }

        private void StopS_Click(object sender, RoutedEventArgs e)
        {
            StopButtonAction.Invoke();
        }

        private void ClearS_Click(object sender, RoutedEventArgs e)
        {
            ClearButtonAction.Invoke();
        }
    }
}
