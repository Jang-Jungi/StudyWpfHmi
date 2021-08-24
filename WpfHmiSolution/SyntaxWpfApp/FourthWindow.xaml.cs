﻿using BusinessLogic;
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
    /// Fourth_Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class FourthWindow : Window
    {
        public FourthWindow()
        {
            InitializeComponent();
        }

        public void Inits()
        {
            List<Car> cars = new List<Car>();   // Car 리스트
            for (int i = 0; i < 10; i++)        // 10 개 데이터를 임의로 생성
            {
                cars.Add(new Car
                {
                    Speed = i * 10,
                    Driver = new Human
                    {
                        FirstName = "Name" + i,
                        HasLicense = true
                    },
                    Color = Color.FromRgb(255, 0, 0)
                });
            }
            this.DataContext = cars; // 데이터를 XAML(화면쪽)으로 보내는 작업
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("good");
        }
    }
}