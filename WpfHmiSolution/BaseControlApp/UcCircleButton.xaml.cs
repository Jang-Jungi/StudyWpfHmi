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

namespace BaseControlApp
{
    /// <summary>
    /// UcCircleButton.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UcCircleButton : UserControl
    {
        #region  1. Routed Event 정의
        public static readonly RoutedEvent CustomClickEvent
            = EventManager.RegisterRoutedEvent("CustomClick", RoutingStrategy.Bubble
                , typeof(RoutedEventHandler), typeof(UcCircleButton));
        #endregion

        #region 2. Routed EventHandler 선언
        public event RoutedEventHandler CustomClick
        {
            add { AddHandler(CustomClickEvent, value); }  // += EventHandler
            remove { RemoveHandler(CustomClickEvent, value); } // -= EventHandler
        }
        #endregion

        #region 3. Button Click Event를 상위로 올려주는 실행
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(CustomClickEvent, sender));
        }
        #endregion

        public UcCircleButton()
        {
            InitializeComponent();
        }

    }
}
