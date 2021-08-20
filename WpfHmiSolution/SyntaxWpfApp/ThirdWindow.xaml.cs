using BusinessLogic;
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
using System.Windows.Shapes;

namespace SyntaxWpfApp
{
    /// <summary>
    /// ThirdWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ThirdWindow : Window
    {
        public ThirdWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //txt.Text = "Meeting";
            //txt.FontSize = 10 ;
            //txt.Foreground = new SolidColorBrush(Colors.Black);
            
            // Car
            Car c = new Car();
            c.Speed = 300;
            c.Color = Colors.White;
            c.Driver = null;

            this.DataContext = c;
            //txt.Text = c.Speed.ToString();
        }
        
    }
}
