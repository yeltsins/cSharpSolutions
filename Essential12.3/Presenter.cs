using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;

namespace Essential12._3
{
    class Presenter
    {
        public MainWindow mainWindow;
        public Model model;

        public Presenter(MainWindow mainw)
        {
            mainWindow = mainw;
            model = new Model();
            mainWindow.StartButtonAction += model.StartTimer;
            mainWindow.StopButtonAction += model.StopTimer;
            mainWindow.ClearButtonAction += model.Clear;
            mainWindow.ClearButtonAction += () => mainWindow.SecondBox.Text = "0";
            model.timer.Elapsed += Timer_Elapsed;
        }



        public void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Application.Current.Dispatcher.BeginInvoke(
              DispatcherPriority.Background,
              new Action(() => this.mainWindow.SecondBox.Text = model.Seconds.ToString()));

        }
    }
}
