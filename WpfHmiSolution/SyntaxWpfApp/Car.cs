﻿using System.Windows.Media;

namespace BusinessLogic 
{
    public class Car : Notifier
    {
        private double speed;
        public double Speed {
            get { return speed; }
            set { OnPropertyChanged("Speed"); }
            }
        public Color Color { get; set; }
        public Human Driver { get; set; }
    }
    public class Human
    {
        public string FirstName { get; set; }
        public bool HasLicense { get; set; }
    }
}